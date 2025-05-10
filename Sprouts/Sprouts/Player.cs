using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SproutsGame
{
    internal class Player
    {
        private string name;
        private bool isTurn;
        public Player(string name_, bool isturn_)
        {
            this.Name = name_;
            this.IsTurn = isturn_;
        }
        public string Name { get => name; set => name = value; }
        public bool IsTurn { get => isTurn; set => isTurn = value; }
    }
}
