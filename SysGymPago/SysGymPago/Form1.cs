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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EngineProcedure Funcion = new EngineProcedure();
            string[] fecha = Funcion.FechasActivas();
            label1.Text = "Hoy : " + fecha[0];
            label6.Text = "Proximo Pago : " + fecha[1];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string cedula = txtCedula.Text;
            string transferencia = txtTransferencia.Text ;
            EngineProcedure Funcion = new EngineProcedure();
            string[] fecha = Funcion.FechasActivas();
            string fechaPago =  fecha[0];
            string fechaExpiracion =  fecha[1];
            if (nombre == string.Empty) { MessageBox.Show("Ingrese Nombre", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            if (apellido == string.Empty) { apellido = "NO INDICADO"; }
            if (cedula == string.Empty) { MessageBox.Show("Ingrese Cedula", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            if (transferencia == string.Empty) { transferencia = "NO INDICADO"; }
            EngineDb MetodoDb = new EngineDb();
            int resultado = MetodoDb.InsertarClientePago(nombre, apellido, cedula, fechaPago, fechaExpiracion, transferencia);
            if (resultado == 1)
            {
                MessageBox.Show("Registro Exitoso", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro Fallido", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTransferencia.Text = string.Empty;
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
    }
}
