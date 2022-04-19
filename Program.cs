using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ttt = new TicTacToe();

            do
            {
                 Console.Clear();
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine(ttt.checkPlayer());
                Console.WriteLine(ttt.view());
                ttt.TargetPoint = int.Parse(Console.ReadLine())-1;
                ttt.markPlayer();

            } while (ttt.State!=1&&ttt.State!=-1);
            Console.Clear();
            Console.WriteLine(ttt.view());
            Console.WriteLine(ttt.winOrdraw());
        }
    }
}
