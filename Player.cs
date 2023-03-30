using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__IndexOverload
{
    internal class Player
    {
        string _firstName;
        string _lastName;

        public Player(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
