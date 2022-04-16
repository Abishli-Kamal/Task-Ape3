using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    abstract class Vehicle
    {

        public int Year { get; set; }
        public string Color { get; set; }
        public abstract void Showinfo();
        public Vehicle(int year)
        {
            Year = year;
        }
    }
   
    
}
