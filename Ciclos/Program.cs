namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(declaramos al variable i y la igualamos a 0; condicion i menor a 10; cada vez que cumpla un ciclo se incrementa i en 1)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Resultado {0}",i);
            }

            //decremento
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Resultado {0}", i);
            }

            //creamos un array string
            string[] arr = { "Dany", "Jose", "Pepito" };
            int[] anio = { 24, 37, 40 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Hola, {0}", arr[i] + " de " + anio[i] + " años ");
            }
            // mas simplificado para obtener los elemtos de una coleccion de datos...
            foreach (var item in arr)
            {
                Console.WriteLine("Hola, {0}", item);
            }
        }
    }
}