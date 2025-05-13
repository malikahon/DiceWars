using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWars.DAL
{
    public class Player
    {

        public int pl_id_19257 { get; set; }

        public string pl_name_19257 { get; set; }

        public bool pl_is_pvp_enabled_19257 { get; set; }

        public DateTime pl_last_game_date_19257 { get; set; }

        public int pl_score_19257 { get; set; }

        public Player()
        {
            pl_last_game_date_19257 = new DateTime(2000, 01, 01);
            pl_score_19257 = 0;
        }
        // we don't need constructors but I like pops of color so why not leave it commented out
        //public Player(string pl_name_19257, bool pl_is_pvp_enabled_19257, DateTime pl_last_game_date_19257, int pl_score_19257)
        //{
        //    this.pl_name = pl_name_19257;
        //    this.pl_is_pvp_enabled = pl_is_pvp_enabled_19257;
        //    this.pl_last_game_date = pl_last_game_date_19257;
        //    this.pl_score = pl_score_19257;
        //}

        public static implicit operator Player(int v)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return pl_name_19257;
        }
    }
}
