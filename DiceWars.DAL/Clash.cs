using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWars.DAL
{
    public class Clash
    {
        // essentially just all the columns in the table
        public int cl_id_19257 { get; set; }

        public Player cl_player1_19257 { get; set; }

        public Player cl_player2_19257 { get; set; }

        public DateTime cl_date_19257 { get; set; }
        
        public enum outcome
        {
            tie = 0,
            player1_won = 1,
            player2_won = 2
        }

        public outcome cl_outcome_19257 { get; set; }


    }
}
