using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGymPago
{
    public class EngineProcedure
    {
        public string  [] FechasActivas (DateTime a)
        {
            string[] fecha = new string[2];
            fecha[0] = a.ToString("dd/MM/yyyy");
            fecha[1] = a.AddDays(30).ToString("dd/MM/yyyy");
            return fecha;
        }
        public DateTime [] FechasActivasDB(DateTime a)
        {
            DateTime [] fecha = new DateTime[2];
            fecha[0] = a;
            fecha[1] = a.AddDays(30);
            return fecha;
        }

        public static DataGridView ColorGrilla(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                else
                    row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
            }
            return grid;
        }
    }
}
