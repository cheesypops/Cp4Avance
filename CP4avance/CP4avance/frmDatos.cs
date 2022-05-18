using System;
using System.Windows.Forms;

namespace CP4avance
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        double total = 0;//valor donde se guarda el total de compra
        private int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0;

        public Pedido orden { get; set;}
        
        //crear botones
        private void btnAceptar_Click(object sender, EventArgs e)//confirmar orden
        {
            //crear objetos
            //crear opciones del menu
            Comida burrito = new Comida("Burrito", 5.99);
            Comida torta = new Comida("Torta", 5.99);
            Comida quesadilla = new Comida("Quesadilla", 5.99);
            Comida papas = new Comida("Papas", 7.99);
            Comida nachos = new Comida("Nachos", 6.99);
            Comida duo = new Comida("Duo Tortas", 15.98);
            
            //crear pedido
            Pedido burrit = new Pedido(burrito, cont1);
            Pedido tort = new Pedido(torta, cont2);
            Pedido quesadill = new Pedido(quesadilla, cont3);
            Pedido papa = new Pedido(papas, cont4);
            Pedido nacho = new Pedido(nachos, cont5);
            Pedido duot = new Pedido(duo, cont6);
        }

        private void btnCancelar_Click(object sender, EventArgs e)//Cancelar orden
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            //kk
        }

        private void btnAdd4_Click(object sender, EventArgs e)//precio 7.99
        {
            cont4++;
            total = total + 7.99;
            lblTotal.Text = "Total: " + total;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void picmenu4_Click(object sender, EventArgs e)
        {
            //
        }

        private void lblDes4_Click(object sender, EventArgs e)
        {
            //
        }

        private void lblPrecio1_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnAdd2_Click(object sender, EventArgs e)//precio 5.99
        {
            cont2++;
            total = total + 5.99;
            lblTotal.Text = "Total: " + total;
        }

        private void btnAdd1_Click(object sender, EventArgs e)//precio 5.99
        {
            cont1++;
            total = total + 5.99;
            lblTotal.Text = "Total: " + total;
        }

        private void btnAdd3_Click(object sender, EventArgs e)//precio 5.99
        {
            cont3++;
            total = total + 5.99;
            lblTotal.Text = "Total: " + total;
        }

        private void btnAdd5_Click(object sender, EventArgs e)//precio 6.99
        {
            cont5++;
            total = total + 6.99;
            lblTotal.Text = "Total: " + total;
        }

        private void btnAdd6_Click(object sender, EventArgs e)//precio 15.98
        {
            cont6++;
            total = total + 15.98;
            lblTotal.Text = "Total: " + total;
        }
    }
}