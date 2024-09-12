using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoApp
{
    internal class Player
    {
        public string Name { get; set; }
        public int Place { get; set; }
        public bool HasController { get; set; }
        public Player(string name, int place, bool hasController) {
            Name = name;
            Place = place;
            HasController = hasController;
        }

        public string ToString()
        {
            return ($"Player: {Name} Controller: {HasController} Place: {Place}");
        }
    }
}
