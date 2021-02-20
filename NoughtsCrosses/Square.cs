using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsCrosses
{
    public enum Player { Noone = 0, Noughts, Crosses}
    struct Square
    {
        public Player Owner { get; }

        public Square(Player owner)
        {
            this.Owner = owner;
        }

        public override string ToString()
        {
            switch (Owner)
            {
                case Player.Noone:
                    return ".";
                case Player.Noughts:
                    return "O";
                case Player.Crosses:
                    return "X";
                default:
                    throw new Exception("Invalid State");
            }
        }


    }
}
