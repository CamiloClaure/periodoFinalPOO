using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace controlForms
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Cuadrado":
                    button1.Visible = true;
                    break;
                case "Circulo":
                    button1.Visible = true;
                    break;
                case "Rectangulo":
                    button2.Visible = true;
                    break;
                case "Triangulo":
                    button2.Visible = true;
                    break;
                case "Trapecio":
                    button3.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int a;
                a = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor del lado o radio: "));
                area(a);
            } catch { MessageBox.Show("Error"); }
            
        }
        
            public void area(int a)
            {
            double r;
            if(comboBox1.Text=="Circulo")
            {
                r = 2 * 3.1416 * a;
            }
            else
            {
                r = a * a;
            }
            MessageBox.Show("El area de la figura es: "+r);
             }
            public void area(int a, int b)
            {
            double r;
            if (comboBox1.Text == "Triangulo")
            {
                r = (b* a)/2;
            }
            else
            {
                r = a * b;
            }
            MessageBox.Show("El area de la figura es: " + r);
        }
            public void area(int a, int b, int h)
            {
            double r;
            r= (((a + b)) * h) / 2;
            MessageBox.Show("El area de la figura es: " + r);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
              string nombre, aP, aM;
              int edad;
              string jefe;
              double salario;
              int numeroCI;
        string lvlStdy;
        string uni, carrera;
        int cMaterias, notas;
        string nombreProy;
        double totalHrsPasantia, nroHrsCmlt;
            try {
                nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre");
                aP = Microsoft.VisualBasic.Interaction.InputBox("Ingrese apellido paterno");
                aM = Microsoft.VisualBasic.Interaction.InputBox("Ingrese apellido materno");
                edad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese edad"));
                numeroCI = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nro CI"));
                lvlStdy = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nivel de estudio");
                uni = Microsoft.VisualBasic.Interaction.InputBox("Ingrese universidad");
                carrera = Microsoft.VisualBasic.Interaction.InputBox("Ingrese carrera");
                cMaterias = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad de materias inscritas"));
                notas = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese notas"));
                nombreProy = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre de proyecto");
                totalHrsPasantia = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese horas totales de pasantia"));
                nroHrsCmlt = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese horas que ha completado"));
                ingenieria emi = new ingenieria(nombre, aP, aM, edad, numeroCI, lvlStdy, uni, carrera, cMaterias, notas, nombreProy, Convert.ToInt32(totalHrsPasantia), Convert.ToInt32(nroHrsCmlt));
                MessageBox.Show("El promedio de notas es: " + emi.prom());
            } catch { MessageBox.Show("Error"); }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor del lado: "));
                b = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor del lado o altura: "));
                area(a, b);

            }
            catch { MessageBox.Show("Error"); }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b,c;
            /* 25 ejercicios cosola bien hecho, char, vector, matrices, recursividad, proyeto, recursividad control , herencia y sobrecarga completo*/
            try {
                a = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor del lado: "));
                b = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor del lado 2: "));
                c = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor del altura: "));

                area(a, b, c);
            } catch { MessageBox.Show("Error"); }
            
        }
    }
    public class persona 
    {
        string nombre, aP, aM;
        int edad;
        public persona(string n, string pat, string mat, int ed)
        {
            nombre = n;
            aP = pat;
            aM = mat;
            edad = ed;
        }
    }
    public class empleado : persona
    {
        string jefe;
        double salario;
        public empleado(string n, string pat, string mat, int ed, string jef, double sal) : base(n, pat, mat, ed)
        {
            jefe = jef;
            salario = sal;
        }
    }
    public class estudiante : persona
    {
        int numeroCI;
        string lvlStdy;
        public estudiante(string n, string pat, string mat, int ed,int ci, string lvl):base(n,pat,mat,ed)
        {
            numeroCI = ci;
            lvlStdy = lvl;
        }

    }
    public class universitario : estudiante

   {
        string uni, carrera;
        int cMaterias, notas;
        public universitario(string n, string pat, string mat, int ed, int ci, string lvl,string u, string carr, int cm, int notas) : base(n, pat, mat, ed, ci, lvl)
        {
            uni = u;
            carrera = carr;
            cMaterias = cm;
            this.notas = notas;
        }

    }
    public class ingenieria: universitario

    {
        string nombreProy;
         double totalHrsPasantia, nroHrsCmlt;
        string notas;
        public ingenieria(string n, string pat, string mat, int ed, int ci, string lvl, string u, string carr, int cm, int notas, string pry, int pst, int hrs) : base(n, pat, mat, ed, ci, lvl,u,carr,cm,notas)
        {
            nombreProy = pry;
            totalHrsPasantia = pst;
            nroHrsCmlt = hrs;
            this.notas = notas.ToString();
            if(u == "EMI")
            {
                MessageBox.Show("Es en la EMI");
            }
            else
            {
                MessageBox.Show("No es en la EMI");
            }
        }
        public string prom()
        {
            return notas;
        }

    }

}
