using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(args[0]);
            Enemy [] enemies = new Enemy [n];
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nome do inimigo {i + 1}");
                string name = Console.ReadLine();
                Enemy enemy = new Enemy(name);
                enemies[i] = enemy;
                
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{enemies[i].GetName()}" +
                $"{enemies[i].GetHealth()} {enemies[i].GetShield()}");
            }
            

        }
    }
}
