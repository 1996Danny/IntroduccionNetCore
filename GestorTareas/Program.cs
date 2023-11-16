namespace GestorTareas
{
    /*
                Ejercicio: Gestión de Tareas Pendientes
                Escribe un programa de consola que permita a un usuario gestionar su lista de tareas pendientes. 
                El programa debe realizar las siguientes tareas:

                Menú Principal:

                Mostrar un menú que incluya las siguientes opciones:
                Agregar tarea
                Mostrar tareas pendientes
                Marcar tarea como completada
                Salir del programa
                Agregar Tareas:

                Permitir al usuario agregar nuevas tareas. Cada tarea debe tener un nombre y una descripción.
                Mostrar Tareas Pendientes:

                Mostrar todas las tareas pendientes con sus nombres y descripciones.
                Marcar Tarea como Completada:

                Permitir al usuario marcar una tarea como completada. Mostrar un mensaje indicando que la tarea ha sido completada.
                Salir del Programa:

                Salir del programa cuando el usuario elija esta opción.
     */
    internal class Program
    {
        static void Main(string[] args)
        {


            List<tarea> tareas = new List<tarea>();

            bool continuar = true;

            do
            {
                //menu
                Console.WriteLine(" - - - - Gestor de Tareas - - - - ");
                Console.WriteLine("1. Agregar una Tarea");
                Console.WriteLine("2. Mostar tareas incompletas");
                Console.WriteLine("3. Completar tarea");
                Console.WriteLine("4. Salir ");
                Console.WriteLine();
                Console.Write("Ingrese una opcion del 1-4: ");
                Console.WriteLine();

                int opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre de la tarea --> ");
                        string nombreTarea = Console.ReadLine();
                        Console.Write("Descripción de la tarea -->  ");
                        string descripcionTarea = Console.ReadLine();
                        tareas.Add(new tarea { Nombre = nombreTarea, Descripcion = descripcionTarea });
                        Console.WriteLine();
                        Console.WriteLine("Tarea guardada");
                        break;
                    case 2:
                        Console.WriteLine("Tareas pendientes");
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("No hay tareas pendientes");
                            Console.WriteLine();

                        }
                        else
                        {
                            foreach (var tarea in tareas)
                            {
                                Console.WriteLine("===============================================================================================");
                                Console.WriteLine($"Nombre: {tarea.Nombre}");
                                Console.WriteLine($"Descripción: {tarea.Descripcion}");
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Ingrese el nombre de la tarea completada: ");
                        string nombreTareaCompletada = Console.ReadLine();
                        var tareaCompletada = tareas.Find(t => t.Nombre == nombreTareaCompletada);
                        if (tareaCompletada != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($" Tarea '{tareaCompletada.Nombre}' completada.");
                            tareas.Remove(tareaCompletada);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Tarea no encontrada.");
                        }
                        break;
                    case 4:
                        continuar = false;
                        Console.WriteLine();
                        Console.Write("Mission Complete!!!");
                        
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opción incorrecta!!!. Intente nuevamente.");
                        Console.WriteLine();
                        break;
                }


            } while (continuar);
        }
    }
    class tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}