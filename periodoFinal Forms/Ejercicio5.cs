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
    public partial class Ejercicio5 : Form
    {//Variables
        int[] n = new int[8];
        int b=0, c=1,f=0;
        public Ejercicio5()
        {
            InitializeComponent();
        }

       

        //procedimientos
        public string getEjercicio8()
        {
            b = 0;
            c = 1;
            f = 0;

            for (int i = 0; i < 8; i++)
            {
                n[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero "+ (i + 1).ToString()));
                listBox1.Items.Add("Numero "+(i+1).ToString() +" = "+ n[i].ToString());
            }

            for (int j = 0; j < 8; j++)
            {
                if (n[j] >= 0)
                {
                    b = b + n[j];
                }
                else
                {
                    c = c * n[j];
                    f++;
                }
            }
            if (f == 0) c = 0;
            listBox1.Items.Add("La suma de los positivos es: " + b);
            listBox1.Items.Add("La multiplicacion de los negativos es: " + c);
            return "";
        }
        //Eventos
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try {

                getEjercicio8();
            } catch { MessageBox.Show("Intentelo de nuevo, entrada no valida");
                listBox1.Items.Clear();

            }
            
        }
    }
}
