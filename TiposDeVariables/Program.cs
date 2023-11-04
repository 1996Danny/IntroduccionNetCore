namespace PracticaNetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir variables segun su tipo(C# es fuetemente tipado)
            int year = Convert.ToInt16("12");
            Console.WriteLine("Hello Danny, {0}", year);

            //float 7 digitos 32bits
            //double 15-16 digitos 64bits
            //decimal 28-29 digitos 128bits (mas exacto)
            double doble = 2.5;
            decimal decimales = 2.07M;
            float flotante = 10.03F;
            Console.WriteLine("Esto es un decimal {0}, {1}, {2}", doble, decimales, flotante);
            
            string name = "Dany";
            String surname = "Sanchez"; // Otra forma de definir un str
            Console.WriteLine("Hola, mi nombre es {0}, {1}", name, surname);

            bool buleano = false;
            bool buleano2 = true;
            Console.WriteLine("Este valor es {0} o {1}", buleano, buleano2);

            char letra = 'A';
            Console.WriteLine("Char solo puede estar entre comillas simples y solo 1 caracter -> {0}", letra);


            //===================================OperacionesAritmeticas==============================================================
            int valor1 = 3;
            int valor2 = 6;
            var suma = valor1 + valor2;
            //var suma = valor1 - valor2;
            //var suma = valor1 * valor2;
            //var suma = valor1 / valor2;
            //var suma = valor1 % valor2; //Resto
            Console.WriteLine("El resultado suma {0} y {1} es {2}",valor1, valor2, suma);
            
            //============================OperadoresAsignacion============================================================
            valor1 += valor2; //incremento y asignación
            //valor1 -= valor2; //decremento y asignación
            //valor1 *= valor2; //multiplicación y asignación
            //valor1 /= valor2; //división y asignación
            //valor1 %= valor2; //resto y asignación
            Console.WriteLine("Valor asignado {0}", valor1);

            //=============================OperadoresComparaciónTipo-Relacionales=======================================
            //var data = valor1 > valor2;
            //var data = valor1 < valor2;
            //var data = valor1 <= valor2;
            var data = valor1 >= valor2;
            Console.WriteLine("El primer valor {1} es menor al segundo valor {2} -> {0}", data, valor1, valor2);

            //===========================OperadoresIgualdad======================================================
            var datos = valor1 == valor2; //igualdad
            //var datos = valor1 != valor2; // distinto
            Console.WriteLine("{0} es igual a {1} : {2}", valor1, valor2, datos);

            //==========================OperadoresLogicos========================================================
            // Operador de negación lógico !
            // Operador AND lógico &
            // Operador OR exclusivo lógico ^
            // Operador OR lógico |
            // Operador AND lógico condicional &&
            // Operador OR lógico condicional ||

            //==========================EstructurasCondicionales================================================

            if (1 > 0 && 10 == 10) //if evalua si la (condición) es verdadera o falsa
            {
                if (true) // condición anidada / if anidado
                {
                    Console.WriteLine("Si la condicion es true, ejecuta el bloque");
                }
                else
                {
                    Console.WriteLine("si es falso se ejecuta este else");
                }
                Console.WriteLine("Ejecutando el bloque dentro de if, porque es verdadera la condicion");
            }
            else
            {
                Console.WriteLine("Sino se ejecuta el bloque else, porque la condicion es falsa");
            }
            // práctica de condicionales
            string FirstName = "Dany";
            //string FirstName = "Pedro";
            if (FirstName == "Dany")
            {
                Console.WriteLine("Buenos días {0}", FirstName);
            }
            else
            {
                Console.WriteLine("Buenos días {0}", FirstName);
            }
            // Operador Condicional(simplicar la estructura if"simple")
            string Saludar = "Hola";
            FirstName = 1==3 ? "Dany" : "Pedro"; // variableAEstudiar = condicion(ToF) ? 1ExpresionAComparar : 2ExpresionAComparar
            Console.WriteLine(Saludar + " " + FirstName);

            //=============================================Arrays-Arreglos===============================================
            //array de tipo string
            string[] cadenas = new string[5]; // tipoDato[] nombreArray = new tipoDato[cantidadElementos]
            //para almacenar datos dentro de nuestro array
            cadenas[0] = "Posicion 1"; // nombreArray[posicionElemento] = Elemento  "Los indices comienzan en 0"
            cadenas[4] = "posicion 5";
            Console.WriteLine(cadenas[0]+" "+ cadenas[4]);
            Console.WriteLine(cadenas[3]);
            string[] cadena2 = { "Hola", "Buenos", "Días" }; // con llaves podemos cargar los datos en el Array
            Console.WriteLine(cadena2);
            Console.WriteLine("El array tiene {0} elementos", cadenas.Length);
            
            //array de tipo int
            int[] edad = new int[2];
            edad[0] = 20;
            edad[1] = 10;
            //edad[2] = 50;
            Console.WriteLine(edad[1]);

            // Arrays multidimensionales
            double[,] Amulti = new double[2,2] { {2, 3.5 }, {4.5, 0.9 } }; //con la [filas,columnas] indicamos la creación de efilas y columnas y entre llaves indicamos los valores
            Console.WriteLine(Amulti[0,1]);

        }
    }
}