using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace DiceWars.DAL
{
    public class DbManager
    {
        // to connect to database via connection string
        protected internal SQLiteConnection Connection 
        { 
            get
            {
                return new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            }
        }
    }
}
