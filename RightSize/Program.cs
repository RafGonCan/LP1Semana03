using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string palavra in args)
            {
                //verify if the word is equal or bigger than 8 if so break the code
                if (palavra.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                //verify if some word is bigger than 3 and write it
                if (palavra.Length > 3)
                {
                    Console.WriteLine(palavra);
                }
            }
        }
    }
}
