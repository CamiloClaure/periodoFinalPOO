using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia

{
    //herencia multiple
    public class persona
    {
        protected string nombre;
        protected int edad;
        protected double peso;
        public persona(string nombre1, int edad1, double peso1)
        {
            nombre = nombre1;
            edad = edad1;
            peso = peso1;

        }

    }
    public class trabajador: persona
    {
        protected int cantanios;
        protected double salario;
        protected string area;
        public trabajador(string nombre1, int edad1, double peso1, int cant1,double salario1,string area1):base(nombre1, edad1, peso1)
        {
            cantanios = cant1;
            salario = salario1;
            area = area1;
        }

    }
    public class secretaria: trabajador
    {
        protected int cantL;
        protected string jefe;
        public secretaria(string nombre1, int edad1, double peso1, int cant1, double salario1, string area1,int cantL1, string jefe1):base(  nombre1, edad1, peso1,cant1, salario1, area1)
        {
            cantL = cantL1;
            jefe = jefe1;
            Console.WriteLine(nombre + " trabaja en area de " + area + " y su jefe es " + jefe);





            if (salario <= 4000)
            {
                Console.WriteLine(" y como gana "+salario+" le aumentaremos");
            }
            else Console.WriteLine("como gana "+salario+" todavia no le aumentaremos");
        }

    }

    //herencia simple
    public class operador
    {
        protected float valor;
        protected float valor1;
        protected float resultado;
        protected void introducir()
        {
            Console.Write("Ingrese valor 1: ");
            valor = float.Parse(Console.ReadLine());
            Console.Write("Ingrese valor 2: ");
            valor1 = float.Parse(Console.ReadLine());
        }
    }
    public class suma : operador
    {
        public  suma()
        {
            Console.WriteLine("*************SUMA!!!***********");
            introducir();
            resultado = valor + valor1;
            Console.WriteLine("La suma es: " + resultado);
        }
    }
    public class resta : operador
    {
        public resta()
        {
            Console.WriteLine("*************RESTA!!!***********");
            introducir();
            resultado = valor - valor1;
            Console.WriteLine("La resta es: " + resultado);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 7;
            int m1 = 4, m2 = 5;
            double i = 6.5, j = 15.3;
            Console.WriteLine("El cuadro del indice es: " + prueba(indice) + "\n");
            Console.Write("El prducto de {0} por {1} es: ", m1, m2);
            Console.WriteLine(prueba(m1,m2));
            Console.Write("El promedio de {0} por {1} es: ", i, j);
            Console.WriteLine(prueba(i, j));

            Console.ReadKey();
        }
        static int prueba(int a)
        {
            return a *a;
        }
        static double prueba(int b, int c)
        {
            return b*c;
        }
        static double prueba(double x, double y)
        {
            return (x+ y)/2;
        }
    }
}