using System;

namespace TorresDeHanoi
{
    class Program
    {
        static void MoverDisco(int n, char origen, char destino, char auxiliar)
        {
            if (n == 1)
            {
                Console.WriteLine($"Mover disco 1 de {origen} a {destino}");
            }
            else
            {
                MoverDisco(n - 1, origen, auxiliar, destino);
                Console.WriteLine($"Mover disco {n} de {origen} a {destino}");
                MoverDisco(n - 1, auxiliar, destino, origen);
            }
        }

        static void Main(string[] args)
        {
            // Título y Subtítulo
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 UNIVERSIDAD ESTATAL AMAZÓNICA        ║");
            Console.WriteLine("║                    Fernando Corrales               ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.WriteLine();

            int numDiscos;

            Console.Write("Ingrese el número de discos: ");
            while (!int.TryParse(Console.ReadLine(), out numDiscos) || numDiscos <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
                Console.Write("Ingrese el número de discos: ");
            }

            Console.WriteLine("\nMovimientos:\n");
            MoverDisco(numDiscos, 'A', 'C', 'B'); // A: origen, C: destino, B: auxiliar

            Console.ReadKey();
        }
    }
}