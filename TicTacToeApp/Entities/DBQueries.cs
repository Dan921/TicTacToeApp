using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeApp.Entities;

namespace TicTacToeApp.Logic
{
    public class DBQueries
    {
        TicTacToeDBEntities ticTacToeDBEntities = new TicTacToeDBEntities();

        public void AddNewRecord(Record record)
        {
            ticTacToeDBEntities.Records.Add(record);
            ticTacToeDBEntities.SaveChanges();
        }
    }
}
