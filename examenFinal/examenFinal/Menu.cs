using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace examenFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 matrices = new Form1();
            matrices.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadenas chain = new Cadenas();
            chain.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vectores vect = new Vectores();
            vect.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            controlForms.Form1 control = new controlForms.Form1();
            control.Show();
        }
    }
}
