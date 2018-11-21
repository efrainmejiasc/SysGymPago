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


        public int InsertarClientePago(string Nombre, string Apellido, string Cedula, string FechaPago , string FechaExpiracion, string NumeroTransferencia )
        {
            int resultado = new int();
            string SQL = "INSERT INTO ClientePago (Nombre,Cedula,FechaPago,FechaExpiracion,NumeroTransferencia) VALUES (@Nombre,@Cedula,@FechaPago,@FechaExpiracion,@NumeroTransferencia)";
            OleDbConnection Conexion = new OleDbConnection(cadenaConexion);
            using (Conexion)
            {
                OleDbCommand command = new OleDbCommand(SQL, Conexion);
                command.CommandType = CommandType.Text;
                Conexion.Open();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Nombre", Nombre + " " + Apellido);
                command.Parameters.AddWithValue("@Cedula", Cedula);
                command.Parameters.AddWithValue("@FechaPago", Convert.ToDateTime(FechaPago)); 
                command.Parameters.AddWithValue("@FechaExpiracion", Convert.ToDateTime(FechaExpiracion));
                command.Parameters.AddWithValue("@NumeroTransferencia", NumeroTransferencia);
                resultado = command.ExecuteNonQuery();
                Conexion.Close();
            }
            return resultado;
        }
    }
}
