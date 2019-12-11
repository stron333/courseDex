using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIEnumerable
{
    class CarPark
    {
        
    }

    class Machine
    {
        public int NumberOfSeats {get; set;}
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Carrying { get; set; }
        public string Mark { get; set; }
        public Machine() { }      
        public Machine(int numberOfSeats, int weight, int height, int width, int carrying, string mark)
        {
            NumberOfSeats = numberOfSeats;
            Weight = weight;
            Height = height;
            Width = width;
            Carrying = carrying;
            Mark = mark;
        }
    }

    class PassengerCar : Machine
    {
        public string License { get; set; }
        public PassengerCar(string license,
                            int numberOfSeats,
                            int weight,
                            int height,
                            int width,
                            int carrying,
                            string mark) : base(numberOfSeats, weight, height, width, carrying, mark)
        {
            License = license;
        }
    }
    static class PassengerCars
    {
        public static PassengerCar Audi()
        {
            return new PassengerCar("",5, 123, 123, 324, 4000, "Audi");
        }
        public static PassengerCar BMW()
        {
            return new PassengerCar("", 5, 654, 700, 500, 5000, "BMW");
        }
    }
}
