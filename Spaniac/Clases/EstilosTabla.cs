using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaniac.Clases
{
    public class EstilosTabla
    {
        /* Representa la tabla a la que le pasaremos los estilos. */
        private DataGridView miTabla;

        public EstilosTabla(DataGridView tabla)
        {
            this.miTabla = tabla;
        }

        public void estiloCabecera()
        {
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();

            cabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cabecera.BackColor = Color.MidnightBlue;
            cabecera.ForeColor = Color.White;
            cabecera.Font = new Font("Reem Kufi", 10, FontStyle.Bold);

            this.miTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.miTabla.ColumnHeadersHeight = 40;
            this.miTabla.ColumnHeadersDefaultCellStyle = cabecera;
            this.miTabla.EnableHeadersVisualStyles = false;
        }

        public void estiloFila()
        {
            DataGridViewCellStyle fila = new DataGridViewCellStyle();

            fila.Alignment = DataGridViewContentAlignment.MiddleCenter;
            fila.BackColor = Color.White;
            fila.ForeColor = Color.Black;
            fila.Font = new Font("Reem Kufi", 10, FontStyle.Regular);

            this.miTabla.DefaultCellStyle = fila;
        }
    }
}
