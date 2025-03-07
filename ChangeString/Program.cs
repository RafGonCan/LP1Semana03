using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Ask for a string
            Console.Write("String: ");
            string frase = Console.ReadLine();
            //Ask for a letter
            Console.Write("Caráter: ");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine();

            //replace the old char with the new one
            string newLetter = frase.Replace(letra, 'x');
            Console.WriteLine("Será impresso: " + newLetter);
        }
    }
}
