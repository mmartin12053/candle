using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace candle
{
    class Program
    {
        int num = 1;
        public static void Main(string[] args)
        {

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|            welcome to my game candle.                           |");
            Console.WriteLine("|            you will have four options when you start.           |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|            1: light                                             |");
            Console.WriteLine("|            this action will light a new candle while            |");
            Console.WriteLine("|            decreasing sleep and hunger.                         |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|            2: eat                                               |");
            Console.WriteLine("|            this action will make you less hungery               |");
            Console.WriteLine("|            losing you sleep and depleating your                 |");
            Console.WriteLine("|            candle.                                              |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|            3: sleep                                             |");
            Console.WriteLine("|            this action will make you well rested                |");
            Console.WriteLine("|            but extremely hungry and                             |");
            Console.WriteLine("|            burns your candle out faster.                        |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|            4: wait                                              |");
            Console.WriteLine("|            this action will make you waste time                 |");
            Console.WriteLine("|            and decreases your light hunger and sleep.           |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("|            note: this game is weird and is prone to crash.      |");
            Console.WriteLine("|                                                                 |");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("press any key to continue");
            Console.ReadKey();

            game.gameMain();
            

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
