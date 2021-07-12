using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_part2_part3
{
    // Решение задания 2 и 3
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string player1 = " ", player2 = " ", player3 = " ", player4 = " ", player5 = " ";
            int gameNumber, gameNumberMax, gameNumberMin, userTry, userTryMax, userTryMin, complexity, numPlayers, winner;
            string gameRules = "Правила игры:\n-Загадывается число в установленном диапозоне. Назовём его gameNumber." +
                 "\n-Игроки по очереди выбирают число из заданного диапозона.Пусть это число обозначается как userTry." +
                  "\n-UserTry после каждого хода вычитается из gameNumber,а само gameNumber выводится на экран" +
                  "\n-Если после хода игрока gameNumber равняется нулю, то походивший игрок оказывается победителем.";
            Console.WriteLine(gameRules);
            Console.WriteLine("Выберите уровень сложности(0-легкий, 1-средний, 2-сложный)");
            switch (complexity = int.Parse(Console.ReadLine()))
            {
                case 0:
                    Console.WriteLine("Выбран легкий уровень.");
                    Console.WriteLine("Введите диапозон для генерации gameNumber в интервале от 30 до 100: ");
                    Console.Write("gameNumberMin = ");
                    gameNumberMin = int.Parse(Console.ReadLine());
                    Console.Write("gameNumberMax = ");
                    gameNumberMax = int.Parse(Console.ReadLine());
                    if (gameNumberMin < 30 || gameNumberMin > gameNumberMax || gameNumberMax > 100)
                    {
                        Console.WriteLine("Вы установили некорректный диапазон! Диапозон автоматически установлен от 30 до 100");
                        gameNumberMin = 30;
                        gameNumberMax = 100;
                    }
                    Console.WriteLine("Введите диапозон для userTry в интервале от 10 до 20: ");
                    Console.Write("userTryMin = ");
                    userTryMin = int.Parse(Console.ReadLine());
                    Console.Write("userTryMax = ");
                    userTryMax = int.Parse(Console.ReadLine());
                    if (userTryMin < 10 || userTryMin > userTryMax || userTryMax > 20)
                    {
                        Console.WriteLine("Вы установили некорректный диапазон! Диапозон автоматически установлен от 10 до 20");
                        userTryMin = 10;
                        userTryMax = 20;
                    }
                    break;
                case -1:
                case 1:
                    Console.WriteLine("Выбран средний уровень.");
                    Console.WriteLine("Введите диапозон для генерации gameNumber в интервале от 100 до 250: ");
                    Console.Write("gameNumberMin = ");
                    gameNumberMin = int.Parse(Console.ReadLine());
                    Console.Write("gameNumberMax = ");
                    gameNumberMax = int.Parse(Console.ReadLine());
                    if (gameNumberMin < 100 || gameNumberMin > gameNumberMax || gameNumberMax > 250)
                    {
                        Console.WriteLine("Вы установили некорректный диапазон! Диапозон автоматически установлен от 100 до 250");
                        gameNumberMin = 100;
                        gameNumberMax = 250;
                    }
                    Console.WriteLine("Введите диапозон для userTry в интервале от 5 до 15: ");
                    Console.Write("userTryMin = ");
                    userTryMin = int.Parse(Console.ReadLine());
                    Console.Write("userTryMax = ");
                    userTryMax = int.Parse(Console.ReadLine());
                    if (userTryMin < 5 || userTryMin > userTryMax || userTryMax > 15)
                    {
                        Console.WriteLine("Вы установили некорректный диапазон! Диапозон автоматически установлен от 5 до 15");
                        userTryMin = 5;
                        userTryMax = 15;
                    }

                    break;
                case -2:
                case 2:
                default:
                    Console.WriteLine("Выбран сложный уровень.");
                    Console.WriteLine("Введите диапозон для генерации gameNumber в интервале от 250 до 500: ");
                    Console.Write("gameNumberMin = ");
                    gameNumberMin = int.Parse(Console.ReadLine());
                    Console.Write("gameNumberMax = ");
                    gameNumberMax = int.Parse(Console.ReadLine());
                    if (gameNumberMin < 250 || gameNumberMin > gameNumberMax || gameNumberMax > 500)
                    {
                        Console.WriteLine("Вы установили некорректный диапазон! Диапозон автоматически установлен от 250 до 500");
                        gameNumberMin = 250;
                        gameNumberMax = 500;
                    }
                    Console.WriteLine("Введите диапозон для userTry в интервале от 1 до 10: ");
                    Console.Write("userTryMin = ");
                    userTryMin = int.Parse(Console.ReadLine());
                    Console.Write("userTryMax = ");
                    userTryMax = int.Parse(Console.ReadLine());
                    if (userTryMin < 1 || userTryMin > userTryMax || userTryMax > 10)
                    {
                        Console.WriteLine("Вы установили некорректный диапазон! Диапозон автоматически установлен от 1 до 10");
                        userTryMin = 1;
                        userTryMax = 10;
                    }
                    break;

            }
            Console.WriteLine("Введите количество игроков(от 2 до 5)  или 1 для игры с компьютером:");
            switch (numPlayers = int.Parse(Console.ReadLine()))
            {
                case 1: 
                    Console.WriteLine("Вы играете против компьютера");
                    Console.WriteLine("Имя Игрок 1: ");
                    player1 = Console.ReadLine();
                    gameNumber = rand.Next(gameNumberMin, gameNumberMax);
                    userTry = 0;
                    winner = 0;
                    while (gameNumber != 0)
                    {
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player1}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }

                            winner = 1;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            if (gameNumber < userTryMax)
                                userTry = rand.Next(userTryMin, gameNumber + 1);
                            else
                                userTry = rand.Next(userTryMin, userTryMax + 1);
                            Console.WriteLine($"Компьютер: {userTry} ");

                            winner = 0;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin&&gameNumber!=0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                    }
                        break;
                case 2:
                    Console.WriteLine("Участвуют 2 игрока");
                    Console.WriteLine("Имя Игрок 1: ");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 2: ");
                    player2 = Console.ReadLine();
                    gameNumber = rand.Next(gameNumberMin, gameNumberMax);
                    userTry = 0;
                    winner = 0;
                    while (gameNumber != 0)
                    {
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player1}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                       
                            winner = 1;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player2}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                         
                            winner = 2;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                    }
                    break;
                case 3:
                    Console.WriteLine("Участвуют 3 игрока");
                    Console.WriteLine("Имя Игрок 1: ");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 2: ");
                    player2 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 3: ");
                    player3 = Console.ReadLine();

                    gameNumber = rand.Next(gameNumberMin, gameNumberMax);
                    userTry = 0;
                    winner = 0;
                    while (gameNumber != 0)
                    {
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player1}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 1;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player2}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }

                            winner = 2;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player3}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 3;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                    }
                    break;
                case 4:
                    Console.WriteLine("Участвуют 4 игрока");
                    Console.WriteLine("Имя Игрок 1: ");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 2: ");
                    player2 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 3: ");
                    player3 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 4: ");
                    player4 = Console.ReadLine();

                    gameNumber = rand.Next(gameNumberMin, gameNumberMax);
                    userTry = 0;
                    winner = 0;
                    while (gameNumber != 0)
                    {
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player1}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 1;
                        }

                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player2}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 2;
                        }

                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player3}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 3;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player4}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 4;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                    }
                    break;
                case 5:
                default:
                    Console.WriteLine("Участвуют 5 игроков");
                    Console.WriteLine("Имя Игрок 1: ");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 2: ");
                    player2 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 3: ");
                    player3 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 4: ");
                    player4 = Console.ReadLine();
                    Console.WriteLine("Имя Игрок 5: ");
                    player5 = Console.ReadLine();

                    gameNumber = rand.Next(gameNumberMin, gameNumberMax);
                    userTry = 0;
                    winner = 0;
                    while (gameNumber != 0)
                    {
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player1}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 1;
                        }

                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player2}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 2;
                        }

                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player3}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 3;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player4}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 4;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                        while (userTry > userTryMax || userTry < userTryMin)
                        {
                            Console.WriteLine($"Введите число от {userTryMin} до {userTryMax}");
                            Console.Write($"{player5}: ");
                            userTry = int.Parse(Console.ReadLine());
                            if (userTry > userTryMax || userTry < userTryMin)
                            {
                                Console.WriteLine($"Некорекктное число(не подадает в диапозон от {userTryMin} до {userTryMax})!!!Повторите ввод...");
                                continue;
                            }
                            if ((userTry > gameNumber) && (gameNumber > 0 && gameNumber <= userTryMax))
                            {
                                Console.WriteLine($"Некорекктное число(gameNumber = {gameNumber}" +
                                    $", а вы ввели {userTry}!!!Повторите ввод...");
                                userTry = 0;
                            }
                            winner = 5;
                        }
                        gameNumber -= userTry;
                        Console.WriteLine($"\n>>>gameNumber = {gameNumber}\n");
                        if (gameNumber < userTryMin && gameNumber != 0)
                        {
                            userTryMax = gameNumber - 1;
                            userTryMin = 1;
                            Console.WriteLine($"Т.к gameNumber < userTryMin то диапозон выбираемых чисел устанавливается от {userTryMin} до {userTryMax}.");
                        }
                        if (gameNumber == 0) break;
                        userTry = 0;
                    }
                    break;
            }
            switch (winner)
            {
                case 0: Console.WriteLine("Победил Компьютер! Поздравляем!!!!"); break;
                case 1: Console.WriteLine($"Победил {player1}! Поздравляем!!!!"); break;
                case 2: Console.WriteLine($"Победил {player2}! Поздравляем!!!!"); break;
                case 3: Console.WriteLine($"Победил {player3}! Поздравляем!!!!"); break;
                case 4: Console.WriteLine($"Победил {player4}! Поздравляем!!!!"); break;
                case 5: Console.WriteLine($"Победил {player5}! Поздравляем!!!!"); break;
            }
            Console.ReadKey();
        }

    }
}
