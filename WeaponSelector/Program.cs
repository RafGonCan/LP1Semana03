using System;

namespace WeaponSelector
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {
            Weapons myWeapon = Weapons.None | Weapons.SilverBullet | Weapons.Garlic | Weapons.HolyWater;
            EnemyType myEnemy = EnemyType.Zombie | EnemyType.Vampire | EnemyType.Werewolf | EnemyType.Ghost;

            if ((myWeapon & Weapons.SilverBullet) == Weapons.SilverBullet)
            {
                myEnemy ^= EnemyType.Zombie;
                myEnemy ^= EnemyType.Werewolf;
                Console.WriteLine($"{myEnemy} dies");
            }
            if ((myWeapon & Weapons.Garlic) == Weapons.Garlic)
            {
                myEnemy ^= EnemyType.Vampire;
                Console.WriteLine($"{myEnemy} dies");
            }
            if ((myWeapon & Weapons.HolyWater) == Weapons.HolyWater)
            {
                myEnemy ^= EnemyType.Vampire;
                myEnemy ^= EnemyType.Ghost;
                Console.WriteLine($"{myEnemy} dies");
            }
            else
            {
                Console.WriteLine($"{myEnemy} survives");
            }
        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            if ((weapons & Weapons.SilverBullet) == Weapons.SilverBullet)
            {
                
            }
            else
            {
                Console.WriteLine($"{enemy} survives");
            }
        }

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {
            
        }
    }
}
