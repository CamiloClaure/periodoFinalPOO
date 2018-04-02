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
{//Matrices Practico
    public partial class Form1 : Form
    {
        
        int m, n,p;
        int posx = 1, posy = 11;
        int[] vector;
        myTextBox[,] texto;
        myTextBox[,] textoV, resultado;
        int[,] matriz1, matriz2, matriz3;
        public Form1()
        {
            InitializeComponent();
        }
        // Funciones
        
        public void eliminar(int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    groupBox1.Controls.Remove(texto[i, j]);
                    groupBox2.Controls.Remove(textoV[i, j]);
                    groupBox3.Controls.Remove(resultado[i, j]);
                    texto[i, j].Dispose();
                    textoV[i, j].Dispose();
                    resultado[i, j].Dispose();

                }
            }
        }
        public void eliminar(int mm, int nn, int pp)
        {
            for (int i = 0; i < mm; i++)
            {
                for (int j = 0; j < nn; j++)
                {

                    groupBox1.Controls.Remove(texto[i, j]);
                    texto[i, j].Dispose();
                    
                }
            }
            for (int i = 0; i < nn; i++)
            {
                for (int j = 0; j < pp; j++)
                {
                    groupBox2.Controls.Remove(textoV[i, j]);
                    textoV[i, j].Dispose();
                }
            }
            for (int i = 0; i < mm; i++)
            {
                for (int j = 0; j < pp; j++)
                {

                    
                    groupBox3.Controls.Remove(resultado[i, j]);
                    
                    resultado[i, j].Dispose();

                }
            }
        }
        public void generar(int m, int n)
        {
            
            texto = new myTextBox[m, n];
            textoV = new myTextBox[m, n];
            matriz1 = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    texto[i,j] = new myTextBox();
                    textoV[i, j] = new myTextBox();
                    texto[i, j].Location = new Point(posx, posy);
                    texto[i, j].Size = new System.Drawing.Size(20, 20);
                    texto[i, j].indiceX = i;
                    texto[i, j].indiceY = j;
                    texto[i, j].Text = "0";
                    groupBox1.Controls.Add(texto[i, j]);
                   
                    posx += 21;
                }
                posx = 1;
                posy += 21;
            }
            posx = 1;
            posy = 11;
           
        }
        public void generar1(int m, int n)
        {
            textoV = new myTextBox[m, n];
            matriz2 = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    textoV[i, j] = new myTextBox();
                    textoV[i, j].Location = new Point(posx, posy);
                    textoV[i, j].Size = new System.Drawing.Size(20, 20);
                    textoV[i, j].indiceX = i;
                    textoV[i, j].indiceY = j;
                    textoV[i, j].Text = "0";
                    groupBox2.Controls.Add(textoV[i, j]);

                    posx += 21;
                }
                posx = 1;
                posy += 21;
            }
            posx = 1;
            posy = 11;
        }
        public void generarR(int m, int n)
        {
            resultado = new myTextBox[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultado[i, j] = new myTextBox();
                    resultado[i, j].Location = new Point(posx, posy);
                    resultado[i, j].Size = new System.Drawing.Size(20, 20);
                    resultado[i, j].indiceX = i;
                    resultado[i, j].indiceY = j;
                    resultado[i, j].Text = matriz3[i, j].ToString();
                    resultado[i, j].Visible = true;
                    groupBox3.Controls.Add(resultado[i, j]);

                    posx += 21;
                }
                posx = 1;
                posy += 21;
            }
            posx = 1;
            posy = 11;
           
           
        }
        public void calcular(int x,int y)
        {
           
           
            matriz3 = new int[x,y];
           
                
                switch (comboBox1.Text)
                {
                    case "Suma":
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {

                                matriz1[i, j] = int.Parse(texto[i, j].Text);

                                matriz2[i, j] = int.Parse(textoV[i, j].Text);

                            }

                        }
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {

                                matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
                            }

                        }

                        break;
                    case "Multiplicacion":
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {

                                matriz1[i, j] = int.Parse(texto[i, j].Text);
                            }

                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < p; j++)
                            {
                                
                                matriz2[i, j] = int.Parse(textoV[i, j].Text);

                            }

                        }
                        for (int fl = 0; fl < m; fl++)
                        {
                            for (int cl = 0; cl < n; cl++)
                            {
                                for (int aux = 0; aux < n; aux++)
                                {
                                matriz3[fl, cl] += matriz1[fl, aux] * matriz2[aux, cl];
                                }
                            }
                        }
                        break;
                }
            //} catch { MessageBox.Show("Error!!!", "Error"); }
            
            
            generarR(x,y);
        }

      

        public void otros()
        {
            matriz3 = new int[m, n];
            try {
                switch (comboBox1.Text)
                {
                    case "Ejercicio1":
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {

                                matriz3[i, j] = int.Parse(texto[i, j].Text);
                            }

                        }
                        break;

                    case "Diagonal principal":
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                if (i == j) matriz3[i, j] = int.Parse(texto[i, j].Text);
                            }
                        }

                        break;
                    case "Identidad":
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                if (i == j) matriz3[i, j] = 1;
                            }
                        }
                        break;

                    case "Transpuesta":
                        matriz3 = new int[m, m];
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                matriz3[i, j] = int.Parse(texto[j, i].Text);

                            }

                        }
                        break;
                    case "Ordenar":
                        vector = new int[m * n];
                        int op = 0;
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                vector[op] = int.Parse(texto[i, j].Text);
                                op++;
                            }

                        }
                        Array.Sort(vector);
                        op = 0;
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                matriz3[i, j] = vector[op];
                                op++;
                            }

                        }
                        break;
                    case "Matriz":
                        for (int q = 0; q < m; q++)
                        {
                            for (int w = 0; w < m; w++)
                            {
                                if (w % 2 != 0)
                                {
                                    matriz3[q, w] = 0;
                                }
                                else
                                {
                                    matriz3[q, w] = 1;
                                }
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Ingrese un valor al combobox");
                        break;
                }
            } catch { MessageBox.Show("Error!!!", "Error"); }
            
            generarR(m, n);
        }
        //Eventos
        private void button2_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Multiplicacion")
            {
                eliminar(m, n, p);
            }
            else { eliminar(m, n); }
            
            button2.Enabled = false;
            button4.Enabled = false;
            comboBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button4.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try {
                switch (comboBox1.Text)
                {
                    case "Ejercicio1":
                        m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor m de su vector"));
                        n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor n de su matriz"));
                        generar(m, n);
                        break;

                    case "Diagonal principal":
                        m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor m de su matriz"));
                        n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor n de su matriz"));
                        generar(m, n);

                        break;
                    case "Identidad":
                        m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor m de su matriz"));
                        n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor n de su matriz"));
                        generar(m, n);
                        break;
                    case "Suma":
                        m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor m de su matriz"));
                        n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor n de su matriz"));
                        generar(m, n);
                        generar1(m, n);
                        break;
                    case "Multiplicacion":
                        m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor m de su matriz 1"));
                        n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor n de su matrices"));
                        p = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor p de su matriz 2"));
                        generar(m, n);
                        generar1(n, p);
                        break;
                    case "Transpuesta":
                        m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor m de su matriz"));
                        generar(m, m);
                        break;
                    case "Ordenar":
                        m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor m de su matriz"));
                        n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor n de su matriz"));
                        generar(m, n);
                        break;
                    case "Matriz":
                        m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor m de su matriz"));
                        n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor n de su matriz"));
                        generar(m, n);
                        break;
                    default:
                        MessageBox.Show("Ingrese un valor al combobox");
                        break;

                }
                button2.Enabled = true;
                button4.Enabled = true;
                comboBox1.Enabled = false;
                button1.Enabled = false;
            } catch { MessageBox.Show("Error!!!","Error"); }
            
            
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
               
                case "Suma":
                    calcular(m, n);
                    break;
                case "Multiplicacion":
                    calcular(m, p);
                    break;
                
                default:
                    otros();
                    break;

            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class myTextBox : TextBox
    {
        public int indiceX,indiceY, indice;
    }
}
