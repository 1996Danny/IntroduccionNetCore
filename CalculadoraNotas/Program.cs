namespace CalculadoraNotas
    /*
 
    Escribe un programa que solicite al usuario ingresar las notas de los estudiantes en una clase.
    El programa debería realizar las siguientes tareas:

    Entrada de Datos:

    Solicitar al usuario que ingrese las notas de los estudiantes una por una.
    Utilizar una lista para almacenar estas notas.
    Cálculo de Estadísticas:

    Calcular y mostrar la cantidad de estudiantes.
    Calcular y mostrar la media (promedio) de las notas.
    Calcular y mostrar la nota más alta y más baja.
    Filtrar Notas:

    */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del estudiante a calificar: ");

            string estudiante = Console.ReadLine(); 
            List<double> notas = new List<double>();
            bool continuar = true;

            do
            {
                Console.Write("Ingrese la nota del estudiante: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas.Add(nota);

                Console.Write("¿Desea ingresar otra nota? S/N: ");
                char respuesta = Console.ReadLine().ToUpper()[0];
                continuar = (respuesta == 'S');

            } while (continuar);

            //calculos
            int cantidadNotas = notas.Count;
            double promedio = notas.Average();
            double notaMaxima = notas.Max();
            double notaMinima = notas.Min();

            Console.WriteLine($"Las notas del {estudiante} son: ");
            Console.WriteLine($"Cantidad de notas es: {cantidadNotas}");
            Console.WriteLine($"Nota promedio: {promedio}");
            Console.WriteLine($"Nota máxima: {notaMaxima}");
            Console.WriteLine($"Nota mínima: {notaMinima}");
        }
    }
}