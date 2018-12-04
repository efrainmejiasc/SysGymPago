using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGymPago
{
    public class EngineDb
    {
        private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\GymPago.accdb";


        public int InsertarActualizarClientePago(string SQL,int Id , string Nombre, string Apellido, string Cedula, string FechaPago , string FechaExpiracion, string NumeroTransferencia )
        {
            int resultado = new int();
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                OleDbCommand command = new OleDbCommand(SQL, Conexion);
                command.CommandType = CommandType.Text;
                Conexion.Open();
                command.Parameters.Clear();
                if (Apellido != string.Empty)
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre + " " + Apellido);
                }
                else
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                }
                command.Parameters.AddWithValue("@Cedula", Cedula);
                command.Parameters.AddWithValue("@FechaPago", Convert.ToDateTime(FechaPago)); 
                command.Parameters.AddWithValue("@FechaExpiracion", Convert.ToDateTime(FechaExpiracion));
                command.Parameters.AddWithValue("@NumeroTransferencia", NumeroTransferencia);
                if (Id > 0)
                {
                    command.Parameters.AddWithValue("@Id", Id);
                }
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }
            return resultado;
        }

        public DataTable SeleccionarClienteExpirado(string SQL, DateTime FechaExpiracion)
        {
            DataTable dataTabla = new DataTable();
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                OleDbCommand command = new OleDbCommand(SQL, Conexion);
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@FechaExpiracion", FechaExpiracion);
                OleDbDataAdapter dataAdaptador = new OleDbDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }

        public DataTable SeleccionarClienteActivo(string SQL, DateTime FechaExpiracion)
        {
            DataTable dataTabla = new DataTable();
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                OleDbCommand command = new OleDbCommand(SQL, Conexion);
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@FechaExpiracion", FechaExpiracion);
                OleDbDataAdapter dataAdaptador = new OleDbDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }

        public DataTable SeleccionarClienteActivo(string SQL, string Cedula)
        {
            DataTable dataTabla = new DataTable();
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                Conexion.Open();
                OleDbCommand command = new OleDbCommand(SQL, Conexion);
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Cedula", Cedula);
                OleDbDataAdapter dataAdaptador = new OleDbDataAdapter(command);
                dataAdaptador.Fill(dataTabla);
                Conexion.Close();
            }
            return dataTabla;
        }

        public int EliminarCliente(string SQL, int Id)
        {
            int resultado = new int();
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                OleDbCommand command = new OleDbCommand(SQL, Conexion);
                command.CommandType = CommandType.Text;
                Conexion.Open();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Id", Id);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }
            return resultado;
        }


    }
}
