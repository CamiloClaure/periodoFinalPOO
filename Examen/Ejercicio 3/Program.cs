using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    #region Ejercicio3


    public class ejercicio5
    {
        public int sumR(int[] v, int n)
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
    public class ejercicio10
    {
        public void suma(int[,] mat, int a, int b)
        {
            int[] vect = new int[a * b];
            int cont = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    vect[cont] = mat[i, j];
                    cont++;
                }
            }
            ejercicio5 maximo = new ejercicio5();
            Console.WriteLine(maximo.sumR(vect, a * b - 1));
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
                    Console.WriteLine("Digite el valor [{0},{1}]:", (i + 1), (j + 1));
                    matr[i, j] = int.Parse(Console.ReadLine());

                }
            }

            return matr;
        }
    }
    #endregion

    #region Ejercicio4
    public class Empleado
    {
        string nombre, clave;
        int edad;
        public Empleado(string nombre, string clave, int edad)
        {
            this.nombre = nombre;
            this.clave = clave;
            this.edad = edad;
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Clave: "+clave);
            Console.WriteLine("edad: "+edad);
        }
    }
    public class Profesor : Empleado
    {
        string Escolaridad, Cvu;
        public Profesor(string nombre, string clave, int edad, string Escolaridad, string Cvu) : base(nombre, clave, edad)
        {
            this.Escolaridad = Escolaridad;
            this.Cvu = Cvu;
           /* Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Clave: " + clave);
            Console.WriteLine("edad: " + edad);*/
            Console.WriteLine("Escolaridad: " + Escolaridad);
            Console.WriteLine("Cvu: " + Cvu);
        }
    }
    public class Chofer : Empleado
    {
        string Video;
        char TipoLicencia;
        public Chofer(string nombre, string clave, int edad, string video, char tipolicencia) : base(nombre, clave, edad)
        {
            this.Video = video;
            this.TipoLicencia = tipolicencia;
           /* Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Clave: " + clave);
            Console.WriteLine("edad: " + edad);*/
            Console.WriteLine("Video: " + video);
            Console.WriteLine("Tipo de Licencia: " + tipolicencia);
        }
    }
    public class Cantante : Empleado
    {
        string Cancion;
        public Cantante(string nombre, string clave, int edad, string cancion) : base(nombre, clave, edad)
        {
            this.Cancion = cancion;
         /*   Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Clave: " + clave);
            Console.WriteLine("edad: " + edad);*/
            Console.WriteLine("Cancion: " + Cancion);

        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1;
            int dim,dim1;
            Console.WriteLine("Ingrese las dimensiones de la matriz: ");
            dim = int.Parse(Console.ReadLine());
            dim1 = int.Parse(Console.ReadLine());
            matriz1 = new int[dim, dim1];
            llenarMatriz.fillMatriz(matriz1,dim,dim1);
            ejercicio10 objeto = new ejercicio10();
            objeto.suma(matriz1, dim, dim1);

            Console.WriteLine("Salida ejercicio 4");
            Profesor pr = new Profesor("Camilo", "S5899-8", 19, "Secundaria", "No se");
            Console.WriteLine();
            Chofer ch = new Chofer("Camilo", "S5899-8", 19, "RadioMix", 'C');
            Console.WriteLine();
            Cantante ct = new Cantante("Camilo", "S5899-8", 19,"Despacito");
            Console.ReadKey();
        }
    }
}
