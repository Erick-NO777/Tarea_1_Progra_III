using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Progra_III
{
    public class Estudiante
    {
        public string Nombre;
        private int Edad;
        public double Promedio;

        // Verifica si el estudiante es mayor de edad usando un booleano
        public bool EsMayorDeEdad()
        {
            return Edad >= 18; // Retorna true o false
        }

        // Muestra la informacion del estudiante
        public void MostrarInfo()
        {
            Console.WriteLine($"\nNombre: {Nombre}, Promedio: {Promedio}");
        }

        // Metodo para la edad
        public void SetEdad(int edad)
        {
            Edad = edad;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes que desea registrar:");
            int cantidad = int.Parse(Console.ReadLine());

            List<Estudiante> estudiantes = new List<Estudiante>();

            // Ciclo for para ingresar los datos de los estudiantes
            for (int i = 0; i < cantidad; i++)
            {
                Estudiante estudiante = new Estudiante();

                Console.Write("\nIngrese el nombre: ");
                estudiante.Nombre = Console.ReadLine();

                Console.Write("Ingrese la edad: ");
                int edad = int.Parse(Console.ReadLine());
                estudiante.SetEdad(edad);

                Console.Write("Ingrese el promedio: ");
                estudiante.Promedio = double.Parse(Console.ReadLine());

                estudiantes.Add(estudiante);
            }

            // Ciclo while para imprimir informacion de estudiantes con promedio >= 70
            int index = 0;
            while (index < estudiantes.Count)
            {
                if (estudiantes[index].Promedio >= 70)
                {
                    estudiantes[index].MostrarInfo();
                }
                index++;
            }

            Console.WriteLine("\nPresiona enter para salir...");
            Console.ReadLine();
        }
    }
}
