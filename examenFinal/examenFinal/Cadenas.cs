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
    public partial class Cadenas : Form
    {
        public Cadenas()
        {
            InitializeComponent();
        }

        private void Cadenas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Ejercicio 1":
                    ejercicio1 aa = new ejercicio1();
                    aa.inicio1();
                  

                    break;
                case "Ejercicio 2":
                    ejercicio2 ab = new ejercicio2();
                    ab.inicio2();
                    


                    break;
                case "Ejercicio 3":
                    ejercicio3 ac = new ejercicio3();
                    ac.inicio3();
                    break;
                case "Ejercicio 4":
                    ejercicio4 ad = new ejercicio4();
                    ad.inicio4();

                    break;
                case "Ejercicio 5":
                    ejercicio5 ae = new ejercicio5();
                    ae.inicio5();


                    break;
                case "Ejercicio 6":
                    ejercicio6 af = new ejercicio6();
                    af.inicio6();
                    break;
                case "Ejercicio 7":
                    ejercicio7 ag = new ejercicio7();
                    ag.inicio7();
                    break;
                case "Ejercicio 8":
                    ejercicio8 ah = new ejercicio8();
                    ah.inicio8();

                    break;
                case "Ejercicio 9":
                    ejercicio9 ai = new ejercicio9();
                    ai.inicio9();

                    break;
                default:
                    break;
            }
        }
    }
    #region Clases
    class general
    {
        protected string a, b, c, d;
        protected int e = 0, f, g, h, x, y, i, o, u, aa;
        protected char cc;
        protected string respuesta = "", dd, rr;
        protected void llenado()
        {
           
            a = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una cadena: ");
        }

    }
    class ejercicio1 : general
    {
        public void inicio1()
        {
            llenado();
            MessageBox.Show("La cantidad de caracteres que hay es: " + a.Length);
        }
    }
    class ejercicio2 : general
    {
        public void inicio2()
        {
            llenado();
            MessageBox.Show("La cadena invertida es: ");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                MessageBox.Show(" " + a[i]);

            }
        }
    }
    class ejercicio3 : general
    {
        public void inicio3()
        {
             
            a = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una cadena 1: ");
             
            b = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una cadena 2: ");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    e++;
                }
            }
            if (e == a.Length)
            {
                MessageBox.Show("Cadena 1 es prefijo de cadena 2");
            }
            else MessageBox.Show("Cadena 1 no es prefijo de cadena 2");
        }
    }
    class ejercicio4 : general
    {
        public void inicio4()
        {
            
                
                x = 0;
                aa = 0;
                e = 0;
                i = 0;
                o = 0;
                u = 0;
                llenado();
                for (int j = 0; j < a.Length; j++)
                {
                    switch (a[j])
                    {
                        case 'a':
                            x++;
                            aa++;
                            break;
                        case 'e':
                            x++;
                            e++;
                            break;
                        case 'i':
                            x++;
                            i++;
                            break;
                        case 'o':
                            x++;
                            o++;
                            break;
                        case 'u':
                            x++;
                            u++;
                            break;
                        default:
                            break;
                    }
                }

                MessageBox.Show("La cantidad de vocales es: " + x);
                MessageBox.Show("La cantidad de vocal a es: " + aa);
                MessageBox.Show("La cantidad de vocal e es: " + e);
                MessageBox.Show("La cantidad de vocal i es: " + i);
                MessageBox.Show("La cantidad de vocal o es: " + o);
                MessageBox.Show("La cantidad de vocal u es: " + u);
             
            

        }
    }
    class ejercicio5 : general
    {
        public void inicio5()
        {
            llenado();
           
            try
            {
                
                x = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite una posicion: "));
                
                y = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite una cantidad: "));
                MessageBox.Show(a.Substring(x, y));
            }
            catch
            {
                MessageBox.Show("Entrada no valida, enter para continuar");
                inicio5();
            }



        }
    }
    class ejercicio6 : general
    {
        public void inicio6()
        {
            
               
                x = 0;
                aa = 0;
                e = 0;
                i = 0;
                o = 0;
                u = 0;
                llenado();
                for (int j = 0; j < a.Length; j++)
                {
                    switch (a[j])
                    {
                        case 'a':
                            x++;
                            aa++;
                            break;
                        case 'e':
                            x++;
                            e++;
                            break;
                        case 'i':
                            x++;
                            i++;
                            break;
                        case 'o':
                            x++;
                            o++;
                            break;
                        case 'u':
                            x++;
                            u++;
                            break;
                        default:
                            break;
                    }
                }

                if (aa > e && aa > i && aa > o && aa > u)
                {
                MessageBox.Show("La vocal que aparece mas es a ");
                }
                else if (e > aa && e > i && e > o && e > u)
                {
                MessageBox.Show("La vocal que aparece mas es e ");
                }
                else if (i > e && i > aa && i > o && i > u)
                {
                MessageBox.Show("La vocal que aparece mas es i ");
                }
                else if (o > e && o > i && o > aa && o > u)
                {
                MessageBox.Show("La vocal que aparece mas es o ");
                }
                else if (u > e && u > i && u > o && u > aa)
                {
                MessageBox.Show("La vocal que aparece mas es u ");
                }
                else MessageBox.Show("Las vocales son de igual cantidad");

               

        }
    }
    class ejercicio7 : general
    {

        public void inicio7()
        {
            llenado();
            
            cc = char.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el caracter para verificar: "));

            try
            {
                for (int j = 0; j < a.Length; i++)
                {
                    if (a[i + 1] == ' ' && a[i] == cc)
                    {
                        x++;
                    }
                }
                MessageBox.Show("La cantidad de palabras que terminan en el caracter que ingreso es: " + x);
            }
            catch (IndexOutOfRangeException)
            {
                x++;
                MessageBox.Show("La cantidad de palabras que terminan en el caracter que ingreso es: " + x);
            }

        }
    }
    class ejercicio8 : general
    {
        public void inicio8()
        {
            llenado();
            MessageBox.Show("La cantidad de caracteres que hay es: " + a.Length);
        }
    }
    class ejercicio9 : general
    {
        public void inicio9()
        {
            llenado();
           
            rr = Microsoft.VisualBasic.Interaction.InputBox("Que caracter desea reemplazar? "); 
           
            dd = Microsoft.VisualBasic.Interaction.InputBox("Que desea introducir? ");

            b = Convert.ToString(a.Replace(rr, dd));
            MessageBox.Show(b);
        }
    }
    #endregion
}
