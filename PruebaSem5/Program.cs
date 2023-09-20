using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prueba04();
            
        }
        static void Prueba01() {
            //multiplicacion 
            int num = 7;
            for (int i = 1;i<=10;i++) {
                Console.WriteLine(num+ " x "+ i +" = "+(num*i));


            }        
            Console.ReadKey();
        }

        static void Prueba02()
        {
            //Suma de N numeros
            Console.Write("Ingrese la cantidad de números a sumar: ");
            int limite = int.Parse(Console.ReadLine());

            int suma = 0;
            for (int i = 1; i <= limite; i++)
            {

                Console.Write("Ingrese el número " + i + ": ");
                int numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
            }

            Console.WriteLine("La suma es " + suma);
            Console.ReadLine();

        }

        static void Prueba03()
        {
            //N numeros aleatorios

            Console.Write("Ingrese cantidad requerida: ");
            int cantidad = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 1; i <= cantidad; i++)
            {
                int aleatorio = rnd.Next(1, 50 + 1);
                Console.WriteLine("Aleatorio " + i + ": " + aleatorio);
            }
            Console.ReadLine();

        }

        static void Prueba04() { 

            //mostrar menu con 3 opciones

           Console.WriteLine("Ingrese una opcion: \n"
               +"\n1: Mostrar secuencias de 3 "
               +"\n2: Hallar el promedio de notas" 
               +"\n3: Mostrar la tabla de un número");
           int opcion =int.Parse(Console.ReadLine());
            int secuencia = 3;
            int resultado = 0;
            switch (opcion)
            {
                case 1:
                   Console.Write("Ingrese el numero máximo : ");
                    int numMax=int.Parse(Console.ReadLine());
                    Console.Write("La secuencia es: ");
                    for (int i = 3; i <=numMax;i+=3) {
                        Console.Write(i);
                        int res = i + 3;
                        if (res<=numMax) {
                        
                            Console.Write(", ");
                        }
                       
                    }
                    Console.ReadKey();

                    break;
                case 2: 
                   Console.Write("Ingrese el numero de notas: ");
                    int notas=int.Parse(Console.ReadLine());
                    float nota = 0;
                    float promedio = 0f;
                    for (int i = 1;i<=notas;i++) 
                    {
                        Console.Write("Ingrese el número " + i + ": ");
                        int num=int.Parse(Console.ReadLine());
                        nota = nota + num;

                    }
                        promedio = nota / notas;

                    Console.WriteLine(" El promedio es : " + promedio);
                    Console.ReadLine();

                    break;
                case 3:
                    Console.Write(" Ingrese el numero : ");
                    int numero=int.Parse(Console.ReadLine());
                    for (int i = 1;i<=10;i++)
                    {
                        Console.WriteLine(numero + " x "+ i+ " = "+(numero*i));

                    
                    }
                    Console.ReadKey();



                    break;
                default:
                    Console.WriteLine("Escoja una de las opciones correctamente.");
                    break;
            }



            Console.ReadKey();
        }
        
    }
}
