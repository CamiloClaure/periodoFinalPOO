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
    public partial class Ejercicio_9 : Form
    {//Variables
        int b, c,i=0,j=0;
        protected int s, d, er, f = 0;
        string a, excercise;
        protected int[] n = new int[20];
        protected string x, y;
        //Fin variables
        public Ejercicio_9()
        {
            InitializeComponent();
        }


        //Procedimientos
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
        public string getEjercicio9()
        {
            listBox1.Items.Clear();
            
        Again:
            a = Microsoft.VisualBasic.Interaction.InputBox("Digite un numero mayor a 2 cifras");
            b = int.Parse(a);
            c = a.Length;
            if (c <= 2)
            {
                
                MessageBox.Show("El numero tiene que ser mayor  de 2 cifras, ingrese otra vez");
                goto Again;
            }
            else
            {
                i = 0;
                do
                {
                    i++;
                    b = b / 10;

                } while (i < 2);
                listBox1.Items.Add("El resutlado es: " + b.ToString());


            }
            return "";
        }
        public void getEjercicio10()
        {
            listBox1.Items.Clear();
            a = Microsoft.VisualBasic.Interaction.InputBox("Digite un numero para ver si es ascendente o no");
            procedimientoGeneral(a);
            d = 0;

            for (int j = 0; j < c+1; j++) if (n[j] < n[j + 1]) d++;
            if (d == c) listBox1.Items.Add ("Es ascendente");
            else listBox1.Items.Add ("No es ascendente");
        }
        public string getEjercicio11()
        {
            listBox1.Items.Clear();
            a = Microsoft.VisualBasic.Interaction.InputBox("Digite un numero, se comprobaran sus cifras");
            procedimientoGeneral(a);
            x = "";
            y = "";
            i = 0;
            do
            {
                i++;
                if (n[i] < 5) x = x + n[i];

                else y = y + n[i];

            } while (i < c);
            listBox1.Items.Add("Los digitos menores a 5 son: " + x);
            listBox1.Items.Add("Los digitos mayores o iguales a 5 son: " + y);
            return "";
        }
        public string getEjercicio12()
        {

            listBox1.Items.Clear();
            a = Microsoft.VisualBasic.Interaction.InputBox("Digite el numero que desee");
            
            er = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite el numero que quiera comparar"));
            b = int.Parse(a);
            c = a.Length;
            i = 0;
            d = 0;
            f = 0;
            do
            {
                i++;
                j = b % 10;
                b = b / 10;
                if (j == er) d++;
                else f++;

            } while (i < c);
            listBox1.Items.Add("El numero "+a+ " contiene " + d + " digitos iguales a " + er);
            listBox1.Items.Add(" y " + f + " digitos diferentes a " + er);
            return "";
        }
        public void getEjercicio13()
        {
            a = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero para sacrle su cadrado y cubo");
            er = int.Parse(a);
            c = 0;
            d = 0;
            c = er * er;
            d = er * er * er;

            listBox1.Items.Add("El cuadrado del numero es: " + c + " y su cubo es: " + d);
        }


        //Eventos
        private void Ejercicio_9_Load(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                excercise = comboBox1.Text;
                
                switch (excercise)
                {
                    
                    case "Ejercicio 9":
                        getEjercicio9();

                        break;
                    case "Ejercicio 10":
                        getEjercicio10();

                        break;
                    case "Ejercicio 11":
                        getEjercicio11();

                        break;
                    case "Ejercicio 12":
                        getEjercicio12();

                        break;
                    case "Ejercicio 13":
                        getEjercicio13();

                        break;
                }
            }
            catch { MessageBox.Show("Entrada no valida"); }
        }

    }
}
