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
    public partial class Ejercicio14 : Form
    {
        public Ejercicio14()
        {
            InitializeComponent();
        }

        //Procedimientos
        public string getEjercicio14()
        {
            int a, b, r = 0;
            double A = 0;
            string op;
            const double pi = 3.14;
            op = comboBox1.Text;

            switch (op)
            {
                case "Cuadrado":
                    
                    MessageBox.Show("Seleccionó cuadrado");
                    a = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del lado del cuadrado"));
                    A = a * a;
                    listBox1.Items.Add("El area del cuadrado es: " + A);

                    break;
                case "Rectangulo":

                    MessageBox.Show("Seleccionó rectangulo");
                    a = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del lado del rectangulo"));
                    b = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del otro lado del rectangulo"));
                    A = a * b;
                    listBox1.Items.Add("El area del rectangulo es: " + A);
                    break;
                case "Triangulo":

                    MessageBox.Show("Seleccionó triangulo");
                    a = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de la base"));
                    b = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de la altura"));
                    A = (a * b) / 2;
                    listBox1.Items.Add("El area del triangulo es: " + A);
                    break;
                case "Trapecio":

                    MessageBox.Show("Seleccionó trapecio");
                    a = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor dela base 1"));
                    b = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de la base 2"));
                    r = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de la altura"));
                    A = (((a + b)) * r) / 2;
                    listBox1.Items.Add("El area del trapecio es: " + A);
                    break;
                case "Circulo":
                    
                    MessageBox.Show("Seleccionó circulo");
                    r = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de radio"));
                    A = pi * r * r;
                    listBox1.Items.Add("El area del circulo es: " + A);
                    break;
                default:
                    Console.Clear();
                    getEjercicio14();
                    break;
            }
            return "";
        }




        private void button1_Click(object sender, EventArgs e)
        {
            getEjercicio14();
        }
    }
}
