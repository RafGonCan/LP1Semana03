using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string palavra in args)
            {
                //verify if the word is equal or bigger than 8
                if (palavra.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }

            }
        }
    }
}
