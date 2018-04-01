using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlR
{
    public class menu
    {
        int op,a,b;
        string respuesta = "";
        public void getMenu()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Menu para los ejercicios del control:\n1. Ejercicio 1\n2. Ejercicio 2\n3. Ejercicio 3\n4. Ejercicio 4\n5. Ejercicio 5\n6. Salir");
                op = int.Parse(Console.ReadLine());
            }
            catch { getMenu(); }

            switch (op)
            {
                case 1:
                    ejercicio125 exer = new ejercicio125();
                    Console.WriteLine("Este es un algoritmo recursivo que muestra el numero menor de un vector, ingrese la dimension del vector");

                    a = int.Parse(Console.ReadLine());
                    exer.llenar(a);
                    exer.menor();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 1; }
                    else getMenu();
                    break;
                case 2:
                    Console.WriteLine("Este es un algoritmo recursivo que permite sumar los elementos de una matriz, ingrese las dimensiones");
                    ejercicio125 exer1 = new ejercicio125();
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    exer1.llenar(a, b);
                    exer1.intermedio();

                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 2; }
                    else getMenu();
                    break;
                case 3:
                    ejercicio3 q = new ejercicio3();
                    q.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 3; }
                    else getMenu();
                    break;
                case 4:
                    ejercicio4 ec = new ejercicio4();
                    ec.inicio();

                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 4; }
                    else getMenu();
                    break;

                case 5:
                    Console.WriteLine("Este es un algoritmo recursivo que permite sumar los elementos de un vector, ingrese la dimension");
                    ejercicio125 ex = new ejercicio125();
                    a = int.Parse(Console.ReadLine());
                    ex.llenar(a);
                    ex.sumaVect();
                    

                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 3; }
                    else getMenu();
                    break;
                case 6:
                    break;
                default:
                    getMenu();
                    break;
            }

        }
    }
    public class ejercicio125
    {
        private int[,] matriz1;
        private int[] vector1, vector2;
        private int k,a,b;

        public void llenar(int m,int n)
        {
            matriz1 = new int[m, n];
            for(int i =0;i< m; i++)
            {
                for(int j =0;j< n; j++)
                {
                    Console.Write("Digite valor [{0},{1}]: ", i+1, j+1);
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            a = m;
            b = n;
        }
        public void llenar(int m)
        {
            vector1 = new int[m];
            for(int i =0;i< m; i++)
            {
                Console.Write("Digite valor [{0}]: ", i+1);
                vector1[i] = int.Parse(Console.ReadLine());
            }
            k = m;
        }
        public void menor()
        {
            Console.WriteLine("El menor es: "+minR(vector1, k-1, vector1[k - 1]));
        }
        public void sumaVect()
        {
            Console.WriteLine("La suma es: "+sumR(vector1, k-1));
        }
        public void intermedio()
        {
            matrizvector(a, b);
        }

        private int minR(int[] vec, int n, int menor)
        {

            if (n == 0)
            {
                if (menor > vec[n]) return vec[0];

                else return menor;
            }



            else
            {
                if (menor > vec[n]) return minR(vec, n - 1, vec[n]);

                else return minR(vec, n - 1, menor);
            }


        }
        private void matrizvector(int m,int n)
        {
            vector2 = new int[m * n];
            int cont = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vector2[cont] = matriz1[i, j];
                    cont++;
                }
            }
            Console.Write("La suma es: "+sumR(vector2, (m * n)-1));
        }
        private int sumR(int[] v, int n)
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
    public class ejercicio3
    {
        int a;
        public void inicio()
        {
            Console.WriteLine("Ingrese un numero para determinar si es par o impar recurivamente");
            a = int.Parse(Console.ReadLine());
            if (par(a)) Console.WriteLine("Es par");
            else Console.WriteLine("Es impar");
        }
        bool par(int n)
        {
            if (n == 0) return true;
            return impar(n - 1);
        }
        bool impar(int n)
        {
            if (n == 0) return false;
            return par(n - 1);
        }
    }
    public class ejercicio4
    {
        int num1, num2;
        public void inicio()
        {
            Console.WriteLine("algoritmo Recursivo que calcule el maximo comun divisor de 2 numeros, ingrese a continuacion los 2 valores");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La el MCD es: "+mcdR(num1, num2));

        }
        int mcdR(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return mcdR(b, a % b);
        }

    }

    class Program
    {
        static void Main(string[] args)
            
        {/*1. Programar un algoritmo recursivo que muestre el numero menor de un vector. Hecho
           2. Programar un algoritmo Recursivo que permita sumar los elementos de una matriz.Hecho
           3. Programar un algoritmo Recursivo que determine si un numero es impar
           4. Programar un algoritmo Recursivo que calcule el maximo comun divisor de 2 numeros
           5. Programar un algoritmo Recursivo que permita sumar los elementos de un vector. Hecho*/
            menu meny = new menu();
            meny.getMenu();
           
            Console.ReadKey();
        }
    }
}
