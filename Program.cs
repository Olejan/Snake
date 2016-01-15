using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(26, 9);
            Console.WriteLine("============================");
            Console.SetCursorPosition(35, 10);
            Console.WriteLine("Game over");
            Console.WriteLine();
            Console.SetCursorPosition(27, 12);
            Console.WriteLine("Created by:  Oleg Glytenko");
            Console.SetCursorPosition(32, 13);
            Console.WriteLine("My first game!!!");
            Console.SetCursorPosition(26, 14);
            Console.WriteLine("============================");
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
