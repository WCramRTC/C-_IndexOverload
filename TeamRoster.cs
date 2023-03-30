using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__IndexOverload
{
    internal class TeamRoster
    {
        List<Player> _roster;

        public TeamRoster()
        {
            _roster = new List<Player>();
        } // End TeamRoster()

        // To override the indexer, use this[int index], built like property

        public Player this[int index]
        {
            get
            {
                return _roster[index];
            }
            set
            {
                _roster[index] = value;
            }
        } // this[index]

        // Create to let you use the internal lists .Count in a for loop
        public int Count
        {
            get => _roster.Count;
        }

        public void AddPlayer(Player player)
        {
            _roster.Add(player);
        } // AddPlayer

        // Overloading AddPlayer
        public void AddPlayer(string firstName, string lastName)
        {
            AddPlayer(new Player(firstName, lastName));
        } // AddPlayer
    }
}
