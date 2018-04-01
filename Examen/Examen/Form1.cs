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
    public partial class Form1 : Form
    {
        int[] vector = new int[100];
        int[,] matriz;

        int x,y,cont=0;
        public void ejercicio1() { }
        public void ejercicio2() { }
        public void ejercicio3() { }
        public void ejercicio4() { }
        public void ejercicio5() { }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double suma=0, promedio, maximo, minimo;
           
            int[] vect = new int[cont];

            for(int i = 0; i < cont; i++)
            {
                suma += vector[i];
                vect[i] = vector[i];
            }
            promedio = suma / (cont );
            Array.Sort(vect);
            minimo = vect[0];
            maximo = vect[cont - 1];
            txtMax.Text = maximo.ToString();
            txtSuma.Text = suma.ToString();
            txtProm.Text = promedio.ToString();
            txtMin.Text = minimo.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtMax.Text = "";
            txtSuma.Text = "";
            txtProm.Text = ""; ;
            txtMin.Text = "";
            cont = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ejercicio_2 exer = new Ejercicio_2();
            exer.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                vector[cont] = int.Parse(txtNumero.Text);
                listBox1.Items.Add(vector[cont]);
                cont++;
                txtNumero.Text = "";
                txtNumero.Focus();
            } catch { MessageBox.Show("Error!!!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }

    #region Arreglos
    public static class llenarVector
    {
        public static int[] fillVector(int[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese su valor " + i + ":"));
            }

            return vec;
        }
    }
    public static class llenarMatriz
    {
        public static int[,] fillMatriz(int[,] matr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese su valor " + i + "," + j));

                }
            }

            return matr;
        }
    }
    #endregion

}
