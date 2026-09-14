using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerX = 2;
            int playerY = 3;

            int enemyX = 7;
            int enemyY = 5;

            int itemX = 4;
            int itemY = 8;

            while (true)
            {
                DrawGame(playerX, playerY, enemyX, enemyY, itemX, itemY);

                bool quit = MovePlayer(ref playerX, ref playerY);

                if (quit)
                {
                    break;
                }
            }
        }

        static void DrawGame(int playerX, int playerY, int enemyX, int enemyY, int itemX, int itemY)
        {
            Console.Clear();

            Console.WriteLine($"Player: ({playerX}, {playerY})");
            Console.WriteLine($"Enemy: ({enemyX}, {enemyY})");
            Console.WriteLine($"Item: ({itemX}, {itemY})");

            Console.WriteLine();
            Console.WriteLine("Use WASD to move");
            Console.WriteLine("Q to quit");
        }

        static bool MovePlayer(ref int playerX, ref int playerY)
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.W)
            {
                playerY++;
            }
            else if (key == ConsoleKey.S)
            {
                playerY--;
            }
            else if (key == ConsoleKey.A)
            {
                playerX--;
            }
            else if (key == ConsoleKey.D)
            {
                playerX++;
            }
            else if (key == ConsoleKey.Q)
            {
                return true;
            }

            return false;
        }
    }
}