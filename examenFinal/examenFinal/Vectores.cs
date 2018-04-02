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
    public partial class Vectores : Form
    {//procedimientos
        public void salida(int n, int[] R, string exer)
        {
            listBox1.Items.Add("Salida del " + exer + ":");
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(R[i]);
            }
        }

        public Vectores()
        {
            InitializeComponent();
        }
        #region Clases
        public class general
        {
            public int[] a, b, c;
            public string[] name;
            public int n, x, y, d, e;
            public int bimoda, moda = 0, veces = 0;
            public bool existe = false;
        }
        public class ejercicio1 : general
        {

            
            public void llenar()
            {
                MessageBox.Show("Algoritmo de suma de vectores ");

                n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                a = new int[n];
                b = new int[n];
                c = new int[n];

            Again:

                try
                {

                    MessageBox.Show("\nDigite los valores para el primer vector");


                    for (int i = 0; i < n; i++)
                    {

                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", (i + 1).ToString()));
                    }
                    MessageBox.Show("\nDigite los valores para el segundo vector");
                    for (int j = 0; j < n; j++)
                    {
                       
                        b[j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", (j + 1).ToString()));
                    }
                    for (int k = 0; k < n; k++)
                    {
                        c[k] = a[k] + b[k];

                    }
                }
                catch
                {

                    MessageBox.Show("Error intentelo otra vez");
                    goto Again;
                }

            }
            public void mostrar()
            {
                for (int i = 0; i < n; i++) Console.WriteLine(a[i] + " + " + b[i] + " = " + c[i]);
            }
        }
        public class ejercicio2 : general
        {
            
            public void llenar()
            {
                int k = 0;
                try
                {
                    MessageBox.Show("Algoritmo para invertir un vector ");
                   
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para su vector: "));
                    a = new int[n];

                    Console.WriteLine("\nDigite los valores para el primer vector");
                    for (int i = n - 1; i >= 0; i--)
                    {
                        ++k;
                     
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor "+ k+" :" ));

                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }

                
            }
            

        }
        public class ejercicio3 : general
        {
            public ejercicio3()
            {

            }
            public void llenar()
            {
                int k = 0;
                Console.Write("Algoritmo operarios y sus sueldos ");
                try
                {

                   
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                    a = new int[n];
                    name = new string[n];

                    Console.WriteLine("\nDigite los valores para el nombre y sueldo");
                    for (int i = 0; i < n; i++)
                    {
                        ++k;
                        name[i] = Microsoft.VisualBasic.Interaction.InputBox("Nombre " + k + ": ");

                        
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Sueldo " + k + ": "));

                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }
                d = a[0];
                for (int j = 0; j < n; j++)
                {
                    if (d <= a[j]) e = j;
                }
            }
           
        }
        public class ejercicio4 : general
        {
            public ejercicio4()
            {

            }
            public void llenar()
            {
                MessageBox.Show("Algoritmo de resta de vectores ");
                try
                {
                    
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                    a = new int[n];
                    b = new int[n];
                    c = new int[n];
                    MessageBox.Show("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                        
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", i + 1.ToString()));
                    }
                    MessageBox.Show("\nDigite los valores para el segundo vector");
                    for (int j = 0; j < n; j++)
                    {
                        
                        b[j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", j + 1.ToString()));
                    }
                    for (int k = 0; k < n; k++)
                    {
                        c[k] = a[k] - b[k];

                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }

            }
            public void mostrar()
            {
                for (int i = 0; i < n; i++) MessageBox.Show(a[i] + " - " + b[i] + " = " + c[i]);
            }
        }
        public class ejercicio5 : general
        {
            public ejercicio5()
            {

            }
            public void llenar()
            {
                MessageBox.Show("Algoritmo de moda de un vector ");
                try
                {
                    
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para su vector: "));
                    a = new int[n];

                    MessageBox.Show("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                        
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", i + 1.ToString()));
                    }
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (a[j] == a[k])
                            {
                                x += 1;
                                y = a[j];
                            }
                        }
                        if (veces < x)
                        {
                            moda = y;
                            veces = x;

                        }
                        else if (veces == x && moda != y)
                        {
                            bimoda = y;
                            existe = true;

                        }
                        x = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }

            }
            public void mostrar()
            {
                // for (int i = 0; i < n; i++) Console.WriteLine(a[i] + " + " + b[i] + " = " + c[i]);
                if (existe)
                {
                    MessageBox.Show("El vector es bimodal con valores: " + moda + " y " + bimoda + " y aparecen " + veces + " veces");
                }
                else MessageBox.Show("La moda es: " + moda + " y aparece " + veces + " veces");

            }

        }
        public class ejercicio6 : general
        {
            public ejercicio6() { }
            public void llenar()
            {
                MessageBox.Show("Algoritmo de fusion de vectores ");
                try
                {
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para su vector 1 : "));
                    e = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para su vector 2: "));
                    a = new int[n];
                    b = new int[e];
                    c = new int[n + e];
                    MessageBox.Show("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                        
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", i + 1.ToString()));
                    }
                    MessageBox.Show("\nDigite los valores para el segundo vector");
                    for (int j = 0; j < e; j++)
                    {
                        
                        b[j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", j + 1.ToString()));
                    }
                    for (int k = 0; k < (n + e); k++)
                    {
                        if (k < n)
                        {
                            c[k] = a[k];
                        }
                        else c[k] = b[k - n];
                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }

            }
            public void mostrar()
            {
                for (int i = 0; i < (n + e); i++) MessageBox.Show(c[i] + ", ");
            }
        }
        public class ejercicio7 : general
        {
            private void insercion()
            {
                int aux;
                int j;
                for (int i = 0; i < a.Length; i++)
                {
                    aux = a[i];
                    j = i - 1;
                    while (j >= 0 && a[j] > aux)
                    {
                        a[j + 1] = a[j];
                        j--;
                    }
                    a[j + 1] = aux;
                }
            }
            private void shellsort()
            {
                int salto = 0;
                int sw = 0;
                int aux = 0;
                int e = 0;
                salto = a.Length / 2;
                while (salto > 0)
                {
                    sw = 1;
                    while (sw != 0)
                    {
                        sw = 0;
                        e = 1;
                        while (e <= (a.Length - salto))
                        {
                            if (a[e - 1] > a[(e - 1) + salto])
                            {
                                aux = a[(e - 1) + salto];
                                a[(e - 1) + salto] = a[e - 1];
                                a[(e - 1)] = aux;
                                sw = 1;
                            }
                            e++;
                        }
                    }
                    salto = salto / 2;
                }
            }
            private void burbuja()
            {
                int t;
                for (int i = 1; i < a.Length; i++)
                    for (int b = a.Length - 1; b >= i; b--)
                    {
                        if (a[b - 1] > a[b])
                        {
                            t = a[b - 1];
                            a[b - 1] = a[b];
                            a[b] = t;
                        }
                    }
            }
            private void quicksort(int primero, int ultimo)
            {
                int i, j, central;
                double pivote;
                central = (primero + ultimo) / 2;
                pivote = a[central];
                i = primero;
                j = ultimo;
                do
                {
                    while (a[i] < pivote) i++;
                    while (a[j] > pivote) j--;
                    if (i <= j)
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);

                if (primero < j)
                {
                    quicksort(primero, j);
                }
                if (i < ultimo)
                {
                    quicksort(i, ultimo);
                }

            }
            private void directSelection()
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] < a[min])
                        {
                            min = j;
                        }
                    }
                    if (i != min)
                    {
                        int aux = a[i];
                        a[i] = a[min];
                        a[min] = aux;
                    }
                }
            }
            public void llenar()
            {
                MessageBox.Show("Algoritmo de ordenamiento de un vector ");
                try
                {
                   
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                    a = new int[n];

                    MessageBox.Show("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                         a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", i + 1.ToString()));
                    }
                    menuOrdn();
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }


            }
            private void menuOrdn()
            {
               
                int op;
              
                try
                {
                    op = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Por que metodo quiere ordenar? \n1. Insercion\n2. Shell sort\n3. Burbuja\n4. Quick sort\n5. Seleccion directa"));
                    switch (op)
                    {
                        case 1:
                            insercion();
                            break;
                        case 2:
                            shellsort();
                            break;
                        case 3:
                            burbuja();
                            break;
                        case 4:
                            quicksort(0, n - 1);
                            break;
                        case 5:
                            directSelection();
                            break;
                        default:
                            menuOrdn();
                            break;
                    }

                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    menuOrdn();
                }
            }
            public void mostrar()
            {

                for (int i = 0; i < n; i++) MessageBox.Show(a[i].ToString());
            }
        }
        public class ejercicio8 : general
        {
            public void llenar()
            {
                MessageBox.Show("Algoritmo de busqueda de un elemento en un vector ");
                try
                {
                     
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                    a = new int[n];

                    MessageBox.Show("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                       
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", i + 1.ToString()));
                    }
                     
                    d = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite el numero que desea encontrar en el arreglo: "));
                    insercion();
                    menuBusqueda();
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }

            }
            private void insercion()
            {
                int aux;
                int j;
                for (int i = 0; i < a.Length; i++)
                {
                    aux = a[i];
                    j = i - 1;
                    while (j >= 0 && a[j] > aux)
                    {
                        a[j + 1] = a[j];
                        j--;
                    }
                    a[j + 1] = aux;
                }
            }

            private void binaria()
            {
                int l = 0, h = n;
                int m = 0;

                while (l <= h && existe == false)
                {
                    m = (l + h) / 2;
                    if (a[m] == d)
                        existe = true;
                    if (a[m] > d)
                        h = m - 1;
                    else
                        l = m + 1;
                }
                
                if (existe == false)
                { MessageBox.Show("\nEl elemento "+ d.ToString() + " no esta en el arreglo" ); }
                else
                { MessageBox.Show("\nEl elemento "+ d + " esta en la posicion:"+  m + 1 + " despues de ordenarlo"); }
            }
            private void secuencial()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == d)
                    {
                        x = i;
                        existe = true;
                    }
                }
               
                if (existe)
                {
                    MessageBox.Show("El numero "+ d + " existe en la posicion {1} "+ (x + 1) + " despues de ordenarlo");
                }
                else MessageBox.Show("El numero "+ d + " no existe en el arreglo " );
            }
            private void menuBusqueda()
            {
                 
                int op;
            
                try
                {
                    op = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Por que metodo quiere ordenar? \n1. Binaria\n2. Secuencial"));
                    switch (op)
                    {
                        case 1:
                            binaria();
                            break;
                        case 2:
                            secuencial();
                            break;
                        default:

                            menuBusqueda();
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    menuBusqueda();
                }
            }
        }
        public class ejercicio9 : general
        {
            public void llenar()
            {
                int act, ant1 = 0, ant2 = 1;
                MessageBox.Show("Algoritmo de serie de Fibonacci en un vector ");
                try
                {
                     
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                    a = new int[n];
                    a[0] = 0;
                    a[1] = 1;
                    for (int i = 0; i < (n - 2); i++)
                    {
                        act = ant1 + ant2;
                        ant1 = ant2;
                        ant2 = act;
                        a[i + 2] = act;

                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }


            }
            public void mostrar()
            {
                MessageBox.Show("La serie es: ");
                for (int i = 0; i < n; i++) MessageBox.Show(a[i] + " ");
            }

        }
        public class ejercicio10 : general
        {

            public void llenar()
            {
                MessageBox.Show("Algoritmo de numeros pares en un vector ");
                try
                {
                    
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                    a = new int[n];

                    MessageBox.Show("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                         
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", i + 1.ToString()));
                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }


            }
            private int calcular()
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j] % 2 == 0) x++;
                }


                return x;
            }
            public void mostrar()
            {
                y = calcular();
                MessageBox.Show("La cantidad de numeros pares es " + y);
            }
        }
        public class ejercicio11 : general
        {

            public void llenar()
            {
                MessageBox.Show("Algoritmo de numeros negativos en un vector ");
                try
                {
                   
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                    a = new int[n];

                    MessageBox.Show("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                       
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", i + 1.ToString()));
                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }


            }
            private int calcular()
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j] < 0) x++;

                }


                return x;
            }
            public void mostrar()
            {
                y = calcular();
                MessageBox.Show("La cantidad de numeros negativos es " + y);
            }
        }
        public class ejercicio12 : general
        {

            public void llenar()
            {
                MessageBox.Show("Algoritmo de numeros pares y negativos en un vector ");
                try
                {
                     
                    n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite los valores para sus vectores: "));
                    a = new int[n];

                    MessageBox.Show("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                       
                        a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Valor {0}: ", i + 1.ToString()));
                    }
                }
                catch
                {
                    MessageBox.Show("Error intentelo otra vez");
                    llenar();
                }


            }
            private int calcular()
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j] % 2 == 0 && a[j] < 0) x++;
                }


                return x;
            }
            public void mostrar()
            {
                y = calcular();
                MessageBox.Show("La cantidad de numeros pares y negativos es " + y);
            }
        }
        #endregion

        #region Eventos
        private void Vectores_Load(object sender, EventArgs e)
        {
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Ejercicio 1":
                    ejercicio1 aa = new ejercicio1();
                    aa.llenar();
                    salida(aa.n, aa.c, "Ejercicio 1");
                    
                    break;
                case "Ejercicio 2":
                    ejercicio2 ab = new ejercicio2();
                    ab.llenar();
                    
                    salida(ab.n, ab.a, "Ejercicio 2");
                    
                    
                    break;
                case "Ejercicio 3":
                    ejercicio3 ac = new ejercicio3();
                    ac.llenar();
                    listBox1.Items.Add("El sujeto con mayor sueldo es: " + ac.name[ac.e] + " y su sueldo es: " + ac.a[ac.e]);

                    break;
                case "Ejercicio 4":
                    ejercicio4 ad = new ejercicio4();
                    ad.llenar();
                    ad.mostrar();
                    
                    break;
                case "Ejercicio 5":
                    ejercicio5 ae = new ejercicio5();
                    ae.llenar();
                    ae.mostrar();

                    break;
                case "Ejercicio 6":
                    ejercicio6 af = new ejercicio6();
                    af.llenar();
                    af.mostrar();
                    break;
                case "Ejercicio 7":
                    ejercicio7 ag = new ejercicio7();
                    ag.llenar();
                    ag.mostrar();
                    break;
                case "Ejercicio 8":
                    ejercicio8 ah = new ejercicio8();
                    ah.llenar();
                    
                    break;
                case "Ejercicio 9":
                    ejercicio9 ai = new ejercicio9();
                    ai.llenar();
                    ai.mostrar();

                    break;
                case "Ejercicio 10":
                    ejercicio10 aj = new ejercicio10();
                    aj.llenar();
                    aj.mostrar();

                    break;
                case "Ejercicio 11":
                    ejercicio11 ak = new ejercicio11();
                    ak.llenar();
                    ak.mostrar();
                   
                    break;
                case "Ejercicio 12":
                    ejercicio12 al = new ejercicio12();
                    al.llenar();
                    al.mostrar();

                    break;
                default:
                    
                    break;
            }
        }
        #endregion

    }
}
