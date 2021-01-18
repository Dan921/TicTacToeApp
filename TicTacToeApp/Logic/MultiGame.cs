using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeApp.Entities;

namespace TicTacToeApp.Logic
{
    public class MultiGame : Game
    {
        public MultiGame()
        {
            setCurrentPlayer(1);
        }

        public int currentPlayer { get; set; }

        public char currentSymbol { get; set; }

        private void setCurrentPlayer(int num)
        {
            if(num == 1)
            {
                currentPlayer = 1;
                currentSymbol = 'X';
            }
            else
            {
                currentPlayer = 2;
                currentSymbol = 'O';
            }
        }

        new public void putSymbol(int num, char sym)
        {
            arrayOfCells[num] = sym;
        }

        new public void restart()
        {
            base.restart();
            setCurrentPlayer(1);
        }

        public void changePlayer()
        {
            if (currentPlayer == 1)
                setCurrentPlayer(2);
            else
                setCurrentPlayer(1);
        }
    }
}
