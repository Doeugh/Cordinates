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

            Console.WriteLine($"Player: ({playerX}, {playerY})");
            Console.WriteLine($"Enemy: ({enemyX}, {enemyY})");
            Console.WriteLine($"Item: ({itemX}, {itemY})");
        }
    }
}
