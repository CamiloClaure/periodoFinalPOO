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
    public partial class Ejercicio4cs : Form
    {//inicio de variables
        protected int s, b, d, e, f = 0;
        protected string var, a, exercise;
        protected int c = 1;
        protected int i = 0, j = 0;
        protected string x, y;
        protected int[] n = new int[20];
        //Fin variables
        public Ejercicio4cs()
        {
            InitializeComponent();
            comboBox1.Focus();
        }
        //procedimientos
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
        public void getEjercicio5(string a)
        {
            procedimientoGeneral(a);
            d = 0;
            for (int j = 1; j < c; j++)
            {
                if (n[j] != n[j + 1]) d++;

            }
            if (d == 0)
            {
                MessageBox.Show("SON IGUALES", "Respuesta");
            }
            else MessageBox.Show("SON DISTINTOS", "Respuesta");
        }
        public void getEjercicio6(string a)
        {
            procedimientoGeneral(a);
            d = 0;
            b = 0;
            for (int j = 1; j <= c; j++)
            {
                if (n[j] % 2 == 0) d++;
                else b++;

            }
            MessageBox.Show("Contiene " + d + " digitos pares y " + b + " digitos impares", "Respuesta");
            
        }
        public string getEjercicio7(string a)
        {
            procedimientoGeneral(a);
            d = 0;
            for (int j = 1; j <= c; j++)
            {
                d = d + n[j];
            }
            MessageBox.Show("La suma es " + d,"Respuesta");
            return "";
        }



        //Botones y otros elementos
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumero.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                exercise = comboBox1.Text;
                a = txtNumero.Text;
                switch (exercise)
                {
                    case "Ejercicio 4":

                        c = a.Length;
                        MessageBox.Show("La cantidad de digitos es: " + c);
                        break;
                    case "Ejercicio 5":
                        getEjercicio5(a);

                        break;
                    case "Ejercicio 6":
                        getEjercicio6(a);

                        break;
                    case "Ejercicio 7":
                        getEjercicio7(a);

                        break;
                }
            } catch { MessageBox.Show("Entrada no valida"); }
            

            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtNumero.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
