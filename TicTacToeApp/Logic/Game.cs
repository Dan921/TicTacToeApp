using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeApp.Entities;

namespace TicTacToeApp.Logic
{
    public class Game
    {
        private DBQueries dBQueries = new DBQueries();

        protected char[] arrayOfCells = new char[9];

        public void putSymbol(int num, char sym)
        {
            arrayOfCells[num] = sym;
        }

        public bool drawCheck()
        {
            if (arrayOfCells.All(p => p != '\0'))
            {
                saveRecord('\0');
                return true;
            }
            return false;
        }

        public bool victoryCheck(char symbol)
        {
            for (int j = 0; j < 9; j += 3)
            {
                if (arrayOfCells[0 + j] == symbol && arrayOfCells[1 + j] == symbol && arrayOfCells[2 + j] == symbol)
                {
                    saveRecord(symbol);
                    return true;
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (arrayOfCells[0 + j] == symbol && arrayOfCells[3 + j] == symbol && arrayOfCells[6 + j] == symbol)
                {
                    saveRecord(symbol);
                    return true;
                }
            }
            if (arrayOfCells[0] == symbol && arrayOfCells[4] == symbol && arrayOfCells[8] == symbol)
            {
                saveRecord(symbol);
                return true;
            }
            if (arrayOfCells[2] == symbol && arrayOfCells[4] == symbol && arrayOfCells[6] == symbol)
            {
                saveRecord(symbol);
                return true;
            }
            return false;
        }

        protected virtual void saveRecord(char symbol)
        {
            Record record = new Record
            {
                Time = DateTime.Now,
                GameType = (this.ToString() == "TicTacToeApp.Logic.SingleGame") ? "Одиночная игра" : "Игра на двоих",
                Winner = (symbol == '\0') ? "Ничья" : symbol.ToString()
            };
            dBQueries.AddNewRecord(record);
        }

        public void restart()
        {
            arrayOfCells = new char[9];
        }
    }
}
