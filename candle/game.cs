using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace candle
{
    class game
    {
        public static void gameMain(int light = 6, int candles = 50, int hunger = 10, int sleep = 20, int hours = 0, string words = "", int point = 0, int hope = 0)
        {

            Console.Clear();
            if (point >= 200)
            {
                point = 0;
                hope +=1;
            }
            if (hope >= 1)
            {
                if (light <= 0)
                {
                    Console.WriteLine($"game over: you let your candle burn out. hours {hours}" +
                        $"");
                }
                else if (hunger <= 0)
                {
                    Console.WriteLine($"game over: you starved to death. hours {hours}");
                }
                else if (sleep <= 0)
                {
                    Console.WriteLine($"game over: your forgot to sleep. hours {hours}");
                }
                else
                {
                    Console.WriteLine($"hour: {hours}; candles: {candles}; light: {light}; hunger: {hunger}; sleep: {sleep}; hope: {hope}");
                    Console.WriteLine("");
                    Console.WriteLine("light(1) eat(2) sleep(3) wait(4) hope(5)");
                    Console.WriteLine("");
                    Console.WriteLine(words);
                    string action = Console.ReadLine();
                    if (action == "1")
                    {
                        gameMain(6, candles -= 1, hunger -= 2, sleep -= 6, hours += 1, "you lit a new candle.");
                    }
                    else if (action == "2")
                    {
                        gameMain(light -= 1, candles, hunger += 10, sleep -= 4, hours += 1, "you filled your stomach.", point++);
                    }
                    else if (action == "3")
                    {
                        gameMain(light -= 3, candles, hunger -= 4, sleep += 15, hours += 4, "you rested.", point++);
                    }
                    else if (action == "4")
                    {
                        gameMain(light -= 1, candles, hunger -= 2, sleep -= 4, hours += 4, "you waited around.", point++);
                    }
                    else if (action == "5")
                    {
                        gameMain(light = 6, candles = 20, hunger -= 2, sleep -= 4, hours += 4, "your hoped.", point++);
                    }
                    else
                    {
                        gameMain(light, candles, hunger, sleep, hours, "error");
                    }
                }
            }
            if (light <= 0)
            {
                Console.WriteLine($"game over: you let your candle burn out. hours {hours}" +
                    $"");
            }
            else if (hunger <= 0)
            {
                Console.WriteLine($"game over: you starved to death. hours {hours}");
            }
            else if (sleep <= 0)
            {
                Console.WriteLine($"game over: your forgot to sleep. hours {hours}");
            }
            else
            {
                Console.WriteLine($"hour: {hours}; candles: {candles}; light: {light}; hunger: {hunger}; sleep: {sleep}");
                Console.WriteLine("");
                Console.WriteLine("light(1) eat(2) sleep(3) wait(4)");
                Console.WriteLine("");
                Console.WriteLine(words);
                string action = Console.ReadLine();
                if (action == "1")
                {
                    gameMain(6, candles -= 1, hunger -= 2, sleep -= 6, hours += 1, "you lit a new candle.");
                }
                else if (action == "2")
                {
                    gameMain(light -= 1, candles, hunger += 10, sleep -= 4, hours += 1, "you filled your stomach.", point++);
                }
                else if (action == "3")
                {
                    gameMain(light -= 3, candles, hunger -= 4, sleep += 15, hours += 4, "you rested.", point++);
                }
                else if (action == "4")
                {
                    gameMain(light -= 1, candles, hunger -= 2, sleep -= 4, hours += 4, "you waited around.", point++);
                }
                else
                {
                    gameMain(light, candles, hunger, sleep, hours, "error");
                }
            }
        }
    }
}
