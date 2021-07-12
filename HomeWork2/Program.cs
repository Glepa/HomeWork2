using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_part1
{
    // Решение задания 1
    class Program
    {
        static void Main(string[] args)
        {
            string player1, player2;
            string gameRules = "Правила игры:\n-Загадывается число от 12 до 120. Назовём его gameNumber."+
                 "\n-Игроки по очереди выбирают число от одного до четырёх.Пусть это число обозначается как userTry." +
                  "\n-UserTry после каждого хода вычитается из gameNumber,а само gameNumber выводится на экран" +
                  "\n-Если после хода игрока gameNumber равняется нулю, то походивший игрок оказывается победителем.";
            Console.WriteLine(gameRules);
            Console.WriteLine("Имя Игрок 1: ");
            player1 = Console.ReadLine();
            Console.WriteLine("Имя Игрок 2: ");
            player2 = Console.ReadLine();
            Random rand = new Random();
            int gameNumber = rand.Next(12, 121);
            int userTry = 0;
            int winner = 0;
            while (gameNumber != 0)
            {
                while (userTry > 4 || userTry <= 0)
                {
                    Console.WriteLine("Введите число от 1 до 4");
                    Console.Write($"{player1}: ");
                    userTry = int.Parse(Console.ReadLine());
                    if (userTry > 4 || userTry <= 0)
                    {
                        Console.WriteLine("Некорекктное число(не подадает в диапозон от 1 до 4)!!!Повторите ввод...");
                        continue;
                    }
                    if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= 4))
                    {
                        Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                            $", а вы ввели {userTry}!!!Повторите ввод...");
                        userTry = 0;
                    }
                    winner = 1;
                }

                gameNumber -= userTry;
                Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                if (gameNumber == 0) break;
                userTry = 0;
                while (userTry > 4 || userTry <= 0)
                {
                    Console.WriteLine("Введите число от 1 до 4");
                    Console.Write($"{player2}: ");
                    userTry = int.Parse(Console.ReadLine());
                    if (userTry > 4 || userTry <= 0)
                    {
                        Console.WriteLine("Некорекктное число(не подадает в диапозон от 1 до 4)!!!Повторите ввод...");
                        continue;
                    }
                    if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= 4))
                    {
                        Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                            $", а вы ввели {userTry}!!!Повторите ввод...");
                        userTry = 0;
                    }
                    winner = 2;
                }

                gameNumber -= userTry;
                Console.WriteLine($"gameNumber = {gameNumber}");
                if (gameNumber == 0) break;
                userTry = 0;
            }
            switch (winner)
            {
                case 1: Console.WriteLine($"Победил {player1}! Поздравляем!!!!"); break;
                case 2: Console.WriteLine($"Победил {player2}! Поздравляем!!!!"); break;
            }
            Console.ReadKey();
            }
    }
}
