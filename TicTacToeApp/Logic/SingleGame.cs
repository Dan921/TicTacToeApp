using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeApp.Entities;

namespace TicTacToeApp.Logic
{
    public class SingleGame : Game
    {
        private DBQueries dBQueries = new DBQueries();

        public char userSymbol  = 'X';
        public char computerSymbol  = 'O';

        public void changeSymbol()
        {
            char temp = userSymbol;
            userSymbol = computerSymbol;
            computerSymbol = temp;
        }

        public void putSymbol(int num)
        {
            arrayOfCells[num] = userSymbol;
        }

        private int findFreePositionInRowWith(string str)
        {
            for (int j = 0; j < 9; j += 3)
            {
                if (String.Concat(arrayOfCells[0 + j], arrayOfCells[1 + j], arrayOfCells[2 + j]).Replace("\0", "") == str)
                {
                    for (int i = 0 + j; i < 3 + j; i++)
                    {
                        if (arrayOfCells[i] == '\0')
                            return i;
                    }
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (String.Concat(arrayOfCells[0 + j], arrayOfCells[3 + j], arrayOfCells[6 + j]).Replace("\0", "") == str)
                {
                    for (int i = 0 + j; i < 7 + j; i += 3)
                    {
                        if (arrayOfCells[i] == '\0')
                            return i;
                    }
                }
            }
            if (String.Concat(arrayOfCells[0], arrayOfCells[4], arrayOfCells[8]).Replace("\0", "") == str)
            {
                for (int i = 0; i < 9; i += 4)
                {
                    if (arrayOfCells[i] == '\0')
                        return i;
                }
            }
            if (String.Concat(arrayOfCells[2], arrayOfCells[4], arrayOfCells[6]).Replace("\0", "") == str)
            {
                for (int i = 2; i < 7; i += 2)
                {
                    if (arrayOfCells[i] == '\0')
                        return i;
                }
            }
            return -1;
        }

        public int computerTurn()
        {
            var rand = new Random();

            int position = findFreePositionInRowWith(String.Concat(computerSymbol, computerSymbol));
            if (position != -1)
            {
                arrayOfCells[position] = computerSymbol;
                return position;
            }
            else
            {
                position = findFreePositionInRowWith(String.Concat(userSymbol, userSymbol));
                if (position != -1)
                {
                    arrayOfCells[position] = computerSymbol;
                    return position;
                }
                else
                {
                    while (arrayOfCells.Contains('\0'))
                    {
                        int i = rand.Next(0, 9);
                        if (arrayOfCells[i] == '\0')
                        {
                            arrayOfCells[i] = computerSymbol;
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        protected override void saveRecord(char symbol)
        {
            Record record = new Record
            {
                Time = DateTime.Now,
                GameType = (this.ToString() == "TicTacToeApp.Logic.SingleGame") ? "Одиночная игра" : "Игра на двоих",
                Winner = (symbol == '\0') ? "Ничья" : (symbol == userSymbol) ? $"{symbol.ToString()} (Игрок)" : $"{symbol.ToString()} (Компьютер)"
            };
            dBQueries.AddNewRecord(record);
        }
    }
}
