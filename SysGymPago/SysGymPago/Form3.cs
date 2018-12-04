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
    public partial class Form3 : Form
    {
        private int id = 0;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(int identificador , string nombre , string cedula, DateTime fechaPago, string transferencia)
        {
            InitializeComponent();
            dateTimePicker1.Value = fechaPago;
            EngineProcedure Funcion = new EngineProcedure();
            string[] fecha = Funcion.FechasActivas(dateTimePicker1.Value);
            label6.Text = "Proximo Pago : " + fecha[1];
            this.id = identificador;
            txtNombre.Text = nombre;
            txtCedula.Text = cedula;
            txtTransferencia.Text = transferencia;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string transferencia = string.Empty;
            if (txtNombre.Text == string.Empty || txtCedula.Text == string.Empty) { MessageBox.Show("Debe ingresar todos los datos", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            string nombre = txtNombre.Text;
            string cedula = txtCedula.Text;
            if (txtTransferencia.Text == string.Empty) { transferencia = "NO INDICADO"; }else { transferencia = txtTransferencia.Text ; }
            EngineProcedure Funcion = new EngineProcedure();
            string[] fecha = Funcion.FechasActivas(dateTimePicker1.Value);
            string fechaPago = fecha[0];
            string fechaExpiracion = fecha[1];
            string apellido = string.Empty;
            string SQL = "UPDATE ClientePago SET Nombre = @Nombre,Cedula = @Cedula, FechaPago = @FechaPago , FechaExpiracion = @FechaExpiracion, NumeroTransferencia = @NumeroTransferencia  WHERE Id=@Id";
            EngineDb MetodoDb = new EngineDb();
            int resultado = MetodoDb.InsertarActualizarClientePago(SQL,this.id, nombre, apellido, cedula, fechaPago, fechaExpiracion, transferencia);
            if (resultado > 0)
            {
                MessageBox.Show("Actualizacion Exitosa", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            EngineProcedure Funcion = new EngineProcedure();
            string[] fecha = Funcion.FechasActivas(dateTimePicker1.Value);
            label6.Text = "Proximo Pago : " + fecha[1];
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                txtCedula.Text = string.Empty;
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
