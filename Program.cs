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
            int y = 9;
            WriteLine("============================", 26, y++);
            WriteLine("Game over", 35, y++);
            WriteLine("", 26, y += 2);
            WriteLine("Created by:  Oleg Glytenko", 28, y++);
            WriteLine("My first game!!!", 32, y++);
            WriteLine("============================", 26, y++);
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(1000);
            Console.ReadKey();
        }
        static void WriteLine(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(str);
        }
    }
}
