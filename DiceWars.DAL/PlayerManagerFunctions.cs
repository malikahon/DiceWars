using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWars.DAL
{
    partial class PlayerManager
    {
        // sort by name
        public List<Player> Sort()
        {
            var players = GetAll();
            players.Sort(new ByNameComparer());
            return players;
        }
        // compare two names
        private class ByNameComparer : IComparer<Player>
        {
            public int Compare(Player? x, Player? y)
            {
                return string.Compare(x.pl_name_19257, y.pl_name_19257);
            }
        }
        
        // function for filtering by winners and losers
        public List<Player> Filter(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Winners:
                    return GetAll().Where(p => p.pl_score_19257 > 0).Select(p => p).ToList();
                case ByAttribute.Losers:
                    var res = from p in GetAll() where p.pl_score_19257 < 0 select p;
                    return res.ToList();
            }
            return null;
        }
    }
}
