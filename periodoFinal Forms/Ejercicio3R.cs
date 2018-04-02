using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace periodoFinal_Forms
{
    public partial class Ejercicio3R : Form
    {
        protected int s, b, d, e, f = 0;
        protected string var, a;
        protected int c = 1;

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected int i = 0, j = 0;
        protected string x, y;
        public Ejercicio3R()
        {
            InitializeComponent();
            txtNumero.Focus();
        }

        private void Ejercicio3R_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d = int.Parse(txtNumero.Text);
            do
            {
                b = d % 10;
                c = b;
            } while (c > 10);
            MessageBox.Show("El ultimo digito es: " + c);
        }
    }
}
