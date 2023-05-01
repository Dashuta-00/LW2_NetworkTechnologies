using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    public class ParkingLotAppeal
    {
        public DateTime parkingDate, departureDate;
        public int parkingPlace;
        public float parkingCost;
        public void PrintAppeal(bool isFirst)
        {
            if (isFirst) Console.WriteLine("|{0, -7}|{1, -11}|{2, -20}|{3, -20}|", parkingPlace, parkingCost, parkingDate, departureDate);
            else
            {
                Console.WriteLine(" |   |                    |           |          |          |{0, -7}|{1, -11}|{2, -20}|{3, -20}|", parkingPlace, parkingCost, parkingDate, departureDate);
            }
        }
        public ParkingLotAppeal(DateTime parkingDate, DateTime departureDate, int parkingPlace, float parkingCost)
        {
            this.parkingDate = parkingDate;
            this.departureDate = departureDate;
            this.parkingPlace = parkingPlace;
            this.parkingCost = parkingCost;
        }
    }
}
