using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("!Unknown perk!");
                return;
            }

            string cLetras = args[0];
            Perks playerPerks = 0;

            foreach(char letra in cLetras)
            {
                switch(letra)
                {
                    case 'w':
                        playerPerks ^= Perks.WarpShift;
                        break;
                    case 'a':
                        playerPerks ^= Perks.Stealth;
                        break;
                    case 's':
                        playerPerks ^= Perks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }

            if (playerPerks == 0)
            {
                Console.WriteLine("!No perks at all!");
                return;
            }

            Console.WriteLine($"Perks do jogador: {playerPerks}");

            if ((playerPerks & Perks.Stealth) != 0 && (playerPerks & Perks.DoubleJump) != 0);
            {
                Console.WriteLine("!Silent jumper!");
            }

            if ((playerPerks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}
