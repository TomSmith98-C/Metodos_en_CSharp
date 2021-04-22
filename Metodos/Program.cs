using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que suma 2 numeros desde el teclado.");
            Pedir_Datos();
            Console.WriteLine("Fin del programa");
            Console.WriteLine($"Metodo que devuelve algo forma 1: {devuelve()}");
            Console.WriteLine($"Metodo que devuelve algo forma 2: {devuelve1()}");
            Console.WriteLine($"Metodo que devuelve Sobrecarga: {Suma(2,3)}");

        }
        static void Pedir_Datos()
        {
            int a,b;

            Console.WriteLine("Digite un numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite un numero");
            b = int.Parse(Console.ReadLine());
            Operacion(a,b);
        }
        static void Operacion(int num1,int num2)
        {
            int Resultado = num1 + num2;
            Imprimir(Resultado);
        }
        static void Imprimir(int final)
        {
            Console.WriteLine($"El resultado es igual a:{final}");
        }
        static int devuelve() {
            return 1;
        }

        static int devuelve1()=> 4;

        //Sobrecarga de metodos

        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Suma(int a ,int b, int c)
        {
            return a + b + c;
        } 
    }
}
