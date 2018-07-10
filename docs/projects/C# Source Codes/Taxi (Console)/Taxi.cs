using System;

namespace Taxi
{
    //Driver's info
    class Taxi
    {
        public string driverName { get; set; }
        public int taxiCoorX { get; set; }
        public int taxiCoorY { get; set; }
        public Taxi(string name, int x, int y)
        {
            this.driverName = name;
            this.taxiCoorX = x;
            this.taxiCoorY = y;
        }
    }
}
