using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot() 
        {
            numberOfCars++;
        }

        public List<Car> Cars = new List<Car>();
        public static int numberOfCars {  get; set; }
    }
}
