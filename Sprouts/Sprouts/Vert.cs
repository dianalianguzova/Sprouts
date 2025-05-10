using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sprouts;
using System.Threading.Tasks;

namespace SproutsGame
{
    public class Vert
    {
        private int x;
        private int y;
        private int lines; //количество ребер, входящих в вершину 
     
        public Vert(int x_, int y_, int lines_) {
            this.X = x_;
            this.Y = y_;
            this.Lines = lines_;    
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Lines { get => lines; set => lines = value; }
    }
}
