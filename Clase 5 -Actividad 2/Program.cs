using System.Numerics;

namespace actv2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             2	Escriba un programa que defina un arreglo (una tabla) de 3x3, 
                inicialice el arreglo de forma fija en el código (hardcoded) 
                o través del teclado (elija lo que le parezca) y realice las siguientes operaciones:
             2.1	Liste el contenido de la tabla con el siguiente formato (los valores son un ejemplo):
		            3	5	1
		            10	1	45
		            2	4	4
              2.2	Luego muestre los elementos del la diagonal principal 
                    (en el ejemplo de arriba: 3, 1, 4) y los de la diagonal secundaria 
                   (en el ejemplo: 1, 1, 2).
               2.3	Pida el ingreso de un valor entero y búsquelo en el arreglo 
                    mostrando la posición de la primer ocurrencia. Por ejemplo, 
                    si se ingresa el 1 y el arreglo es el que esta arriba debería mostrar: 
                    “Valor encontrado en posición 0,2”. 
                    Si no se encuentra el valor mostrar: “Valor no encontrado en el arreglo”.
             */

            int[,] Matriz = { { 1, 2, 3},
                              { 4, 5, 6},
                              { 7, 8, 9} };


            //Listado de Contenido de Matriz

            for (int fila = 0; fila < Matriz.GetLength(0); fila++)      //getlenght ->(0) ->numero de dimension
            {
                for (int columna = 0; columna < Matriz.GetLength(1); columna++)
                {
                    Console.Write(Matriz[fila, columna] + "\t");
                }
                Console.WriteLine("\n");
            }

            //Muestra Diagonales

            Console.WriteLine("Muestra Diagonal Principal");

            Console.Write(Matriz[0, 0] + "\t");
            Console.Write(Matriz[1, 1] + "\t");
            Console.Write(Matriz[2, 2] + "\t");

            Console.WriteLine("\nMuestra Diagonal Secundaria");

            Console.Write(Matriz[0, 2] + "\t");
            Console.Write(Matriz[2, 0] + "\t");
            Console.Write(Matriz[1, 1] + "\t");


            //Busqueda
            Console.WriteLine("\nIngrese un valor para buscar en la Matriz\n");
            int valorBuscado = int.Parse(Console.ReadLine());

            int filaEncontrada = 1;
            int columnaEncontrada = 1;

            for (int fila = 0; fila < Matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < Matriz.GetLength(1); columna++)
                {
                    if (Matriz[fila, columna] == valorBuscado)
                    {
                        filaEncontrada = fila;
                        columnaEncontrada = columna;
                        break; // Encontramos la primera ocurrencia, salimos del bucle interno
                    }
                }

                if (filaEncontrada != 1)
                {
                    break; // Encontramos la primera ocurrencia, salimos del bucle externo
                }
            }

            if (filaEncontrada != 1)
            {
                Console.WriteLine("Valor encontrado en la posición: [{0},{1}]", filaEncontrada, columnaEncontrada);
            }
            else
            {
                Console.WriteLine("Valor no encontrado en la matriz");
            }

        }
    }
}
