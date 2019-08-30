using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancares
{
    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int ID { get; set; }

        public Player()
        {
            Name = "No name";
            Score = 0;
        }
    }
}
