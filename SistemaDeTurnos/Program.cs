using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeTurnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");

            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("1. Dar un turno");
            Console.WriteLine("2. Actualizar diagnóstico de un paciente");
            Console.WriteLine("3. Cancelar un turno");
            Console.WriteLine("4. Ver turnos");
            Console.WriteLine("5. Ver obras sociales");
            Console.WriteLine("6. Agregar paciente");
            Console.WriteLine("7. Eliminar paciente");
            Console.WriteLine("8. Ver pacientes");

            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("Que desea hacer?");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("opción 1");
                    break;
                case "2":
                    Console.WriteLine("opcion 2");
                    break;
                case "3":
                    Console.WriteLine("opcion 3");
                    break;
                case "4":
                    Console.WriteLine("opcion 4");
                    break;
                case "5":
                    Console.WriteLine("opcion 5");
                    break;
                case "6":
                    Console.WriteLine("opcion 6");
                    break;
                case "7":
                    Console.WriteLine("opcion 7");
                    break;
                case "8":
                    Console.WriteLine("opcion 8");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }

            Console.ReadKey();
        }
    }
}
