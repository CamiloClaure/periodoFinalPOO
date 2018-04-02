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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
            txtNumero.Focus();
        }
        int ant1 = 0;
        int i = 0;
        int ant2 = 1;
        int act = 0;
        int n = 0;
        int a, j;
        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtNumero.Text);
            lsbSerie.Items.Add("0");
            lsbSerie.Items.Add("1");
            for (; i < (n - 2); i++)
            {
                act = ant1 + ant2;
                ant1 = ant2;
                ant2 = act;
                lsbSerie.Items.Add(act.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsbSerie.Items.Clear();
            txtNumero.Text = "";
             ant1 = 0;
             i = 0;
             ant2 = 1;
             act = 0;
             n = 0;
            txtNumero.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtNumero.Text);
            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    lsbSerie.Items.Add(i.ToString());
                }
            }
        }
    }
}
