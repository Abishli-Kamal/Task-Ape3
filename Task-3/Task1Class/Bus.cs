using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    internal class Bus:Vehicle
    {
        private int _passengercount;
        public int PassengerCount
        {
            get { return _passengercount; }
            set
            {
                if (value>0)
                {
                    _passengercount=value;
                }
            }
        }

        public Bus(int year,int passengercount):base(year)
        {
            PassengerCount=passengercount;
        }

        public override void Showinfo()
        {
            Console.WriteLine($"PassengerCount:{PassengerCount} Year{Year}");
        }
    }
}
