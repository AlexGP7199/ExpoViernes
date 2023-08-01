namespace Expo;
class Program
{
    static void Main()
    {
        int[] tablero = new int[100];

        // Inicializamos el tablero con los números del 1 al 100
        for (int i = 0; i < 100; i++)
        {
            tablero[i] = i + 1;
        }

        // Dibujamos el tablero en la consola
        DibujarTablero(tablero);

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void DibujarTablero(int[] tablero)
    {
        Console.WriteLine("===================================");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("|| ");
            for (int j = 0; j < 10; j++)
            {
                int posicion = i * 10 + j; // Calculamos la posición actual en el tablero

                // Aseguramos que no se salga del tablero
                if (posicion < tablero.Length)
                {
                    Console.Write(tablero[posicion].ToString().PadLeft(2));
                }
                Console.Write(" || ");
            }
            Console.WriteLine("\n===================================");
        }
    }

}
