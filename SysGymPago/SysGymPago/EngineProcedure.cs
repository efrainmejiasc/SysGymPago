using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGymPago
{
    public class EngineProcedure
    {
        public string  [] FechasActivas ()
        {
            string[] fecha = new string[2];
            DateTime a = DateTime.Now;
            fecha[0] = a.ToString("dd/MM/yyyy");
            fecha[1] = a.AddDays(30).ToString("dd/MM/yyyy");
            return fecha;
        }
    }
}
