using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.Interfaces;

namespace Abstract_factory
{
    public class Place : IPlace
    {
        public enum Places { Kitchen, Room, Corridor, Garage }

        public Places PlaceName { get; set; }

        public Place(Places name)
        {
            PlaceName = name;
        }

        public void FindPlace()
        {
            //
        }

        public int CalculateRoomSize()
        {
            //
            return 25;
        }
    }
}
