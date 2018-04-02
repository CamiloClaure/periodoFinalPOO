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
    public partial class Ejercicio_15 : Form
    {
        protected int s, b, d, e, f = 0,pr;
        int op = 0;
        protected string var, a;
        protected int c = 1;
        protected int i = 0, j = 0;
        protected string x, y;
        protected int[] n = new int[20];
        string excercise;
        public Ejercicio_15()
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
        public string getEjercicio15()
        {
            a = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero para ver su tabla");
            b = int.Parse(a);
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(b + "x" + i + " = " + (i * b));
            }
            return "";
        }
        public void getEjercicio16()
        {
            a = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero","Digito mayor");
            procedimientoGeneral(a);
            d = n[1];
            for (int j = 1; j <= c; j++)
            {
                if (d <= n[j]) d = n[j];
            }
            listBox1.Items.Add("El numero mayor es: " + d); ;
        }
        public void getEjercicio17()
        {
            a = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero");
            d = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una posicion que quiere verificar"));
            procedimientoGeneral(a);
            
            listBox1.Items.Add("El digito en la posicion " + d + " es " + n[d]); 
        }
        public string getEjercicio18()
        {
            float n, s = 0, a = 0;
            float pr = 0;
            n = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de numeros"));

            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero"));

                s = s + a;
            }
            pr = (s / n);
            listBox1.Items.Add("El promedio es: "+ pr);
            return "";
        }
        public void getEjercicio19()
        {
            c = 0;
            d = 0;
           
            Console.WriteLine("");
            s = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad n de valores que va a digitar"));
            
            for (int i =0; i < s; i++)
            {
                b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero "+(i+1)));

                if (b % 2 == 0) c++;
                else d++;
            }
            listBox1.Items.Add("Hay " + c + " numero(s) par(es) y " + d + " numero(s) impar(es)");

        }
        public void getEjercicio20()
        {
            b = 9;
            d = 0;

            MessageBox.Show("Muestra el numero mayor y menor de una lista de N elementos");
            s = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad n de valores que va a digitar"));

            for (int i = 0; i < s; i++)
            {
                e = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero"));

                if (d <= e) d = e;
                if (b >= e) b = e;
            }
            listBox1.Items.Add("El numero mayor es: " + d + " y el menor es: " + b);

        }
        public void getEjercicio21()
        {
            MessageBox.Show("Este algoritmo verifica si un numero es primo o no");

            Console.WriteLine("Digite un numero");
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad n de valores que va a digitar"));

            for (int i = 1; i <= b; i++) if (b % i == 0) f++;
            if (f == 2) listBox1.Items.Add ("El numero " + b + " es primo");
            else listBox1.Items.Add ("El numero " + b + " no es primo");

        }
        public void getEjercicio22()
        {
            c = 1;
            do
            {
                s = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese El numero del que quiera sacar factorial"));

            } while (s < 0 || s > 20);
            if (s == 0) listBox1.Items.Add("Su factorial es 1");
            else
            {
                for (int i = 1; i <= s; i++)
                {
                    c = c* i;
                }
                listBox1.Items.Add("El factorial es: " + c);
            }
        }
        public string getEjercicio23()
        {
            MessageBox.Show("Algoritmo para ordenar dos numeros de menor a mayor");
            s = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un primer numero"));

            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un segundo numero numero"));

            if (s < b) listBox1.Items.Add("Su orden de menor a mayor es " + s + ", " + b);
            else if (b == s) listBox1.Items.Add("Son iguales " + s + ", " + b);
            else listBox1.Items.Add("Su orden de menor a mayor es " + b + ", " + s);
            return "";
        }
        public string getEjercicio24()
        {
            pr = 0;
            f = 0;
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tope de numero que a a digitar"));

            for (int i = 0; i < b; i++)
            {
                
                s = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor"));

                if (s < 51) f++;
                else pr++;
            }
            listBox1.Items.Add("Hay " + f + " reprobado(s) y " + pr + " aprobado(s)");
            return "";
        }
        public void getEjercicio25()
        {
        
            op = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Bienvenido, ingrse un numero del 1 al 7"));

            if (op < 0)
            {
                do
                {

                    op = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("El numero no pertenece al rango"));

                } while (op <= 0);
            }
            switch (op)
            {
                case 1:
                    
                    MessageBox.Show("El dia es Lunes!");
                    break;

                case 2:
                   
                    MessageBox.Show("El dia es Martes!");
                    break;
                case 3:
                
                    MessageBox.Show("El dia es Miercoles!");
                    break;
                case 4:
                  
                    MessageBox.Show("El dia es Jueves!");
                    break;
                case 5:
                
                    MessageBox.Show("El dia es Viernes!");
                    break;
                case 6:
             
                    MessageBox.Show("El dia es Sabado!");
                    break;
                case 7:
              
                    MessageBox.Show("El dia es Domingo!");
                    break;

                default:
                    Console.Clear();
                    getEjercicio25();
                    break;
                   
            }
        }
        //Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                excercise = comboBox1.Text;

                switch (excercise)
                {

                    case "Ejercicio 15":
                        getEjercicio15();

                        break;
                    case "Ejercicio 16":
                        getEjercicio16();

                        break;
                    case "Ejercicio 17":
                        getEjercicio17();

                        break;
                    case "Ejercicio 18":
                        getEjercicio18();

                        break;
                    case "Ejercicio 19":
                        getEjercicio19();

                        break;
                    case "Ejercicio 20":
                        getEjercicio20();

                        break;
                    case "Ejercicio 21":
                        getEjercicio21();

                        break;
                    case "Ejercicio 22":
                        getEjercicio22();

                        break;
                    case "Ejercicio 23":
                        getEjercicio23();

                        break;
                    case "Ejercicio 24":
                        getEjercicio24();

                        break;
                    case "Ejercicio 25":
                        getEjercicio25();

                        break;
                    
                }
            }
            catch { MessageBox.Show("Entrada no valida"); }
        }
    }
}
