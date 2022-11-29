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

            Console.WriteLine("Que desea hacer?");

            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("1. Dar un turno");
            Console.WriteLine("2. Actualizar diagnóstico de un paciente");
            Console.WriteLine("3. Cancelar un turno");
            Console.WriteLine("4. Ver turnos");
            Console.WriteLine("5. Ver obras sociales");
            Console.WriteLine("6. Agregar paciente");
            Console.WriteLine("7. Eliminar paciente");
            Console.WriteLine("8. Ver pacientes");

            Console.ReadKey();
        }
    }
}
