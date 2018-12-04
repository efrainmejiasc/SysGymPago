using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGymPago
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnVencidos_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT Id,Nombre,Cedula,FechaPago,FechaExpiracion,NumeroTransferencia FROM ClientePago WHERE ID IN( SELECT MAX(ID) FROM ClientePago WHERE FechaExpiracion <= @FechaExpiracion GROUP BY Cedula)";
            string  fechaExpiracion = DateTime.Now.ToString("dd/MM/yyyy");
            EngineDb MetodoDb = new EngineDb();
            DataTable dt = new DataTable();
            dt = MetodoDb.SeleccionarClienteExpirado(SQL, Convert.ToDateTime(fechaExpiracion));
            dataGridView1.DataSource = dt;
            dataGridView1 = EngineProcedure.ColorGrilla(dataGridView1);
            dataGridView1.ClearSelection();
        }

        private void BtnActivos_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT  * FROM ClientePago WHERE FechaExpiracion >= @FechaExpiracion ORDER BY Id ";
            string fechaExpiracion = DateTime.Now.ToString("dd/MM/yyyy");
            EngineDb MetodoDb = new EngineDb();
            DataTable dt = new DataTable();
            dt = MetodoDb.SeleccionarClienteActivo(SQL, Convert.ToDateTime(fechaExpiracion));
            dataGridView1.DataSource = dt;
            dataGridView1 = EngineProcedure.ColorGrilla(dataGridView1);
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cedula = txtCliente.Text;
            if (cedula == string.Empty) { MessageBox.Show("Ingrese Cedula", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            string SQL = "SELECT MAX (Id) AS Id , MAX (Nombre) AS Nombre , MAX(Cedula) AS Cedula, MAX(FechaPago) AS FechaPago , MAX(FechaExpiracion) AS FechaExpiracion, MAX(NumeroTransferencia) AS NumeroTransferencia FROM ClientePago WHERE Cedula = @Cedula AND Id > 0";
            EngineDb MetodoDb = new EngineDb();
            DataTable dt = new DataTable();
            dt = MetodoDb.SeleccionarClienteActivo(SQL, cedula);
            dataGridView1.DataSource = dt;
            dataGridView1 = EngineProcedure.ColorGrilla(dataGridView1);
            dataGridView1.ClearSelection();
        }

        private void Btn5ultimos_Click(object sender, EventArgs e)
        {
            string cedula = txtCliente.Text;
            if (cedula == string.Empty) { MessageBox.Show("Ingrese Cedula", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            string SQL = "SELECT TOP 5 *  FROM ClientePago WHERE Cedula = @Cedula ORDER BY FechaPago DESC";
            EngineDb MetodoDb = new EngineDb();
            DataTable dt = new DataTable();
            dt = MetodoDb.SeleccionarClienteActivo(SQL, cedula);
            dataGridView1.DataSource = dt;
            dataGridView1 = EngineProcedure.ColorGrilla(dataGridView1);
            dataGridView1.ClearSelection();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                txtCliente.Text = string.Empty;
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row.Cells["Id"].Value != DBNull.Value)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string  nombre = row.Cells["Nombre"].Value.ToString();
                string cedula = row.Cells["Cedula"].Value.ToString();
                string fechaPago = row.Cells["FechaPago"].Value.ToString();
                string numeroTransferencia  = row.Cells["NumeroTransferencia"].Value.ToString();
                Form3 f = new Form3(id, nombre, cedula, Convert.ToDateTime(fechaPago), numeroTransferencia);
                f.ShowDialog();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells["Id"].Value != DBNull.Value)
                {
                    int Id = Convert.ToInt32(row.Cells["Id"].Value);
                    string SQL = "DELETE FROM ClientePago WHERE Id = @Id";
                    EngineDb MetodoDb = new EngineDb();
                    int resultado = MetodoDb.EliminarCliente(SQL,Id);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Eliminacion Exitosa", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Eliminacion Fallida", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


    }
}



