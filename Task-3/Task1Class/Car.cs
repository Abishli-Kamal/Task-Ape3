using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    internal class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _maxspeed;
        public int Maxspeed
        {
            get { return _maxspeed; }
            set
            {
                if (value > 0)
                {
                    _maxspeed = value;
                }
            }
        }

      

        public Car(int year, string brand, string model) : base(year)
        {
            Brand = brand;
            Model = model;

        }
        public override void Showinfo()
        {
            Console.WriteLine($"Brand:{Brand}  Model{Model}");
        }
    }
}
