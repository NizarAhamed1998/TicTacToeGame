using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class TicTacToe
    {
        char[] _arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int _player=1;
        int _targetPoint;
        int _state = 0;
       

        public char[] Arr
        {
            get { return _arr; }
            set { _arr = value; }
        }
        public int Player
        {
            get { return _player; }
            set { _player = value; }
        }
        

        public int TargetPoint
        {
            get { return _targetPoint; }
            set { _targetPoint = value; }
        }
       

        public int State
        {
            get { return _state; }
            set { _state = value; }
        }


        public TicTacToe()
        {
            
        }
       

        public string checkPlayer()
        {
            if (Player % 2 == 0)
            {
                return "O 2 Turn";
            }
            else
            {
                return "X 1 Turn";
            }
        }

        public void markPlayer()
        {
            if (Arr[TargetPoint] != 'X' && Arr[TargetPoint] != 'O')
            {
                if (Player % 2 == 0)
                {
                    Arr[TargetPoint] = 'O';
                    Player++;
                }
                else
                {
                    Arr[TargetPoint] = 'X';
                    Player++;
                }
            }
            State = checkWin();
        }

        public int checkWin()
        {
            
            if (Arr[0] == Arr[1] && Arr[1] == Arr[2])
            {
                return 1;
            }
            
            else if (Arr[3] == Arr[4] && Arr[4] == Arr[5])
            {
                return 1;
            }
            
            else if (Arr[6] == Arr[7] && Arr[7] == Arr[8])
            {
                return 1;
            }
            
            else if (Arr[0] == Arr[3] && Arr[3] == Arr[6])
            {
                return 1;
            }
            
            else if (Arr[1] == Arr[4] && Arr[4] == Arr[7])
            {
                return 1;
            }
            
            else if (Arr[2] == Arr[5] && Arr[5] == Arr[8])
            {
                return 1;
            }
            
            else if (Arr[0] == Arr[4] && Arr[4] == Arr[8])
            {
                return 1;
            }
            else if (Arr[2] == Arr[4] && Arr[4] == Arr[6])
            {
                return 1;
            }
            
            else if (Arr[0] != '1' && Arr[1] != '2' && Arr[2] != '3' && Arr[3] != '4' && Arr[4] != '5' && Arr[5] != '6' && Arr[6] != '7' && Arr[7] != '8' && Arr[8] != '9')
            {
                return -1;
            }
            
            else
            {
                return 0;
            }
        }
        public string view()
        {
            return string.Format("     |     |      \n  {0}  |  {1}  |  {2}\n_____|_____|_____ \n     |     |      \n  {3}  |  {4}  |  {5}\n_____|_____|_____ \n     |     |      \n  {6}  |  {7}  |  {8}\n     |     |      ",
                                    Arr[0],Arr[1],Arr[2],Arr[3],Arr[4],Arr[5],Arr[6],Arr[7],Arr[8]);
        }

        public string winOrdraw()
        {
            string x="";
            if (State==1)
            {
                x= "Player  "+((Player%2)+1)+"  Win";
            }
            else
            {
                x = "Match Draw";
            }
            return x;
        }
    }
  
}
