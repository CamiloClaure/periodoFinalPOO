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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fibonacci ew = new Fibonacci();
            ew.Show();
           
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public int s, b, d, e, f = 0;
        public string var, a;
        public int c = 1;

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ejercicio3R io = new Ejercicio3R();
            io.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Ejercicio4cs cuatro = new Ejercicio4cs();
            cuatro.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ejercicio5 excercise = new Ejercicio5();
            excercise.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Ejercicio_9 excercise = new Ejercicio_9();
            excercise.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ejercicio14 ejer = new Ejercicio14();
            ejer.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Ejercicio_15 camilo = new Ejercicio_15();
            camilo.Show();
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
     
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    pictureBox1.Top -= 10;
                    break;
            }
        }

        public int i = 0, j = 0;
        protected string x, y;
        protected int[] n = new int[20];
        protected string varInicial()
        {
            Console.WriteLine("Digite el numero que desee");
            var = Console.ReadLine();
            return var;
        }
        protected void procedimientoGeneral(string a)
        {
            b = int.Parse(a);
            c = a.Length;
            s = a.Length;
            do
            {

                n[s] = b % 10;
                b = b / 10;
                s--;
            } while (s > 0);

        }
    }
}
