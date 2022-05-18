using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP4avance
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void toolBar1_ButtonClick_1(object sender, ToolBarButtonClickEventArgs e)
        {
            using (frmDatos Promociones = new frmDatos())
            {
                DialogResult resultado = Promociones.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    //txtCarrito.AppendText(Promociones.);
                }
            }
        }
    }
}