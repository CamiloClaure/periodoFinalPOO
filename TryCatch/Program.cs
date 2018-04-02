using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class error
    {

    }
    public class tresR
    {//suma de 1-n
        public int numero(int n)
        {
            if (n == 1) return 1;
            return n + numero(n - 1);
        }
    }
    public class factorialR
    {
        public int factorial(int numero)
        {
            if (numero == 0) return 1;

            return numero * factorial(numero - 1);
        }
    }
    public class fibonacciR
    {
        public int fibonacci(int n)
        {
            if (n == 1 || n == 2)
            { return 1; }

            return fibonacci(n - 1) + fibonacci(n - 2);
        }

    }
    public class ejercicio3
    {
        public int potencia(int base1,int numero)
        {
            if (numero == 0) return 1;

            return base1 * potencia(base1,numero - 1);
        }

    }
    public class ejercicio4
    {
        public int sumaR(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return n % 10 + sumaR(n / 10);
        }
    }
    public class ejercicio5
    {
      public  int sumR(int[] v , int n)
        {
            if (n == 0)
            {
                return v[n];
            }
            else
            {
                return sumR(v, n - 1) + v[n];
            }
        }
    }
    public class ejercicio6
    {
        public int multR(int[] v, int n)
        {
            if (n == 0)
            {
                return v[n];
            }
            else
            {
                return multR(v, n - 1) * v[n];
            }
        }
    }
    public class ejercicio7
    {
        public void invertirR(int n)
        {
            Console.Write(n % 10);
            //if(n/10==0)
            if (n > 10)
                invertirR(n / 10);
        }
    }
    public class ejercicio8
    {
       public int minR(int[] vec , int n, int menor)
        {

            if (n == 0) {
                if (menor > vec[n]) return vec[0];

                else return menor;
            }

                

            else{
                if (menor > vec[n]) return minR(vec, n - 1, vec[n]);

                else return minR(vec, n - 1, menor);
            }

                
        }

    }
    public class ejercicio9
    {
        public int maxR(int[] vec, int n, int max)
        {

            if (n == 0)
            { 
                if (max < vec[n]) return vec[0];

                else return max;
        }
            else {
                if (max < vec[n]) return maxR(vec, n - 1, vec[n]);

                else return maxR(vec, n - 1, max);
            }

                
        }
    }
    public class ejercicio10
    {
       public void suma(int[,] mat,int a, int b )
        {
            int[] vect = new int[a * b];
            int cont = 0;
            for (int i = 0;i< a; i++)
            {
                for(int j =0;j< b; j++)
                {
                    vect[cont] = mat[i, j];
                    cont++;
                }
            }
            ejercicio5 maximo = new ejercicio5();
           Console.WriteLine(maximo.sumR(vect, a * b - 1));
        }
    }
    public  class Program
    {
        
       
        static void Main(string[] args)
        {
            int a = 1, b = 0, c = 0;
           
            string respuesta = "",x;
            bool falg = false;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int[,] vector;
            vector = new int[a,a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    vector[i,j] = int.Parse(Console.ReadLine());
                }
            }
            ejercicio10 exe = new ejercicio10();
            exe.suma(vector,a,b);


            /*  do
              {
                  try
                 {
                      Console.Clear();
                      Console.WriteLine("Ingrese un numero para su serie");
                     // x = Console.ReadLine();
                      a = int.Parse(Console.ReadLine());
                    //   b = int.Parse(Console.ReadLine());
                      ejercicio4 exer = new ejercicio4();
                     // exer.invertirR(a);
                     Console.WriteLine(exer.sumaR(a));

                      Console.WriteLine("\nDesea continuar? s? n?");
                      respuesta = Console.ReadLine().ToLower();
                      falg = false;
                 }
                 catch
                  {
                      Console.Clear();
                      Console.WriteLine("Nel");
                      falg = true;
                }
              } while (respuesta == "s" || falg == true);*/


            Console.ReadKey();
        }
        public void llenarVector(int m)
        {
            

        }
    }

}