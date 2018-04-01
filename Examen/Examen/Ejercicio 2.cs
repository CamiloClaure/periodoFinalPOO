using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Ejercicio_2 : Form
    {
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangulo rect = new Rectangulo();
            pictureBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuadrado scu = new Cuadrado();
            pictureBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Circulo circ = new Circulo();
            pictureBox3.Visible = true;
        }
    }
    public class IFigura
    {
       protected float A,P, l1,l2,ra;
        const float pi= 3.14f;
       
       public void dibujar(string nombre)
        {
            switch (nombre)
            {
                case "Cuadrado":
                    

                    break;
                case "Rectangulo":

                    break;
                case "Circulo":

                    break;
            }
        }
       public float area(float a, float b)
        {
            A = a * b;

            return A;
        }
        public float area(float r)
        {
            A = pi*r*r;
                            
            return A;
        }
        public float perimetro(float a, float b)
        {
            P = a + a + b + b;
            return P;
        }
        public float perimetro(float r)
        {
            P = pi * r;
            return P;
        }
        
        
    }
    public class Cuadrado: IFigura
    {
        public Cuadrado()
        {
            try
            {
                l1 = float.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del lado del cuadrado"));
                MessageBox.Show("El Area es:" + area(l1, l1).ToString());
                MessageBox.Show("El Perimetro es:" + perimetro(l1, l1).ToString());

                
            }
            catch { MessageBox.Show("Error"); }
             }
    }
    public class Rectangulo : IFigura
    {
        public Rectangulo()
        {
            try
            {
                l1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del lado 1 del cuadrado"));
                l2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del lado 2 del cuadrado"));
                MessageBox.Show("El Area es:" + area(l1, l2).ToString());
                MessageBox.Show("El Perimetro es:" + perimetro(l1, l2).ToString());
            }
            catch { MessageBox.Show("Error"); }
        }
    }
    public class Circulo : IFigura
    {
        public Circulo()
        {
            try
            {
                ra = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del radio del cuadrado"));
                MessageBox.Show("El Area es:" + area(ra).ToString());
                MessageBox.Show("El Perimetro es:" + perimetro(ra).ToString());
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
