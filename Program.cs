using System;

//Se decide utilizar una estructura por dias y por materia, para asi poder optener la asistencia correcta de cada estudiante en el trayecto de la semana


namespace Primer_Parcial__Programacion_2
{
    internal class Program
    {
        static string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
        static string[] materias = { "Español", "Matematicas", "Ciencias", "Ciencias Sociales" };
        static int maxEstudiantes = 30;

        static string[,,] registros = new string[dias.Length, materias.Length, maxEstudiantes];

        static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n----Menú de Asistencia---");
                Console.WriteLine("1. Registrar Estudiante");
                Console.WriteLine("2. Eliminar Estudiante ");
                Console.WriteLine("3. Consultar por materia y dia");
                Console.WriteLine("4. Consultar por dia completo");
                Console.WriteLine("5. salir");
                Console.WriteLine(" Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: RegistrarEstudiante(); break;
                    case 2: EliminarEstudiante(); break;
                    case 3: ConsultarPorMateriaYDia(); break;
                    case 4: ConsultarporDiacompleto(); break;
                    case 5: Console.WriteLine("Saliendo del sistema:"); break;
                    default: Console.WriteLine("Opcion Invalida: "); break;
                }
            } while (opcion != 5);
        }
        static void RegistrarEstudiante()
        {
            int dia = SeleccionarDia();
            int materia = SeleccionarMateria();

            Console.WriteLine("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            if (ExisteEstudiante(dia, materia, nombre))
            {
                Console.WriteLine("El estudiante ya esta registrado en esta materia y diá");
                return;

            }
            for (int i = 0; i < maxEstudiantes; i++)
            {
                if (registros[dia, materia, i] = n == nombre)
                {
                    registros[dia, materia, i] = null;
                    Console.WriteLine("Estudiante no se encontr+o en esa materia y dia");
                    return;

                }
            }
            Console.WriteLine("El estudiante no se encontro en esa materia y dia. ");
        }
        static void ConsultarPorMateriaYDia()
        {
            int dia = SeleccionarDia();
            int materia = SeleccionarMateria();

            Console.WriteLine($"Estudiante en {materias[materia]} el día{dias[dia]}");
            for (int i = 0; 1 < maxEstudiantes; i++)
            {
                if (!string.IsNullOrEmpty(registros[dia, materia, i]))
                    Console.WriteLine($"-{registros[dia, materia, i]}");
            }
        }
        static void ConsultarPorDiaCompleto()
        {
            int dia = SeleccionarDia();

            for (int m = 0; m < materias.Length; m++)
            {
                {
                    Console.WriteLine($"\n{materias[m]};");
                    for (int i = 0; i < maxEstudiantes; i++)
                    {
                        if (!string.IsNullOrEmpty(registros[dia, m, i]))
                            Console.WriteLine($"-{registros[dia, m, i]}");
                    }
                }
            }
            static int SeleccionarDia()
            {
                Console.WriteLine("Seleccione un dia: ");
                for (int i = 0; i < dias.Length; i++)
                    Console.WriteLine(($"{i}. {dias[i]}");

                int dia = int.Parse(Console.ReadLine());
                return dia;
            }
            static int SeleccionarMateria()
            {
                Console.WriteLine("Seleccione una materia");
                for (int i = 0; i < materias.Length; i++)
                    Console.WriteLine(($"{i}. {materias[i]}");

                int materia = int.Parse(Console.ReadLine());
                return materia;
            }

            static bool ExisteEstudiante(int dia, int materia, string nombre)
            {
                for (int i = 0; i < maxEstudiantes; i++)
                    if (registros[dia, materia, i] == nombre)
                        return true;
            }
            return false;
        }
    }
