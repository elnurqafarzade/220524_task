using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22052024_task
{
   
    public class Car
    {
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int Fuelfor1km;
        public double Mileage;

        public void Drive(int km)
        {
            if (CurrentFuel > km)
            {
                CurrentFuel = CurrentFuel - (Fuelfor1km * km);
                Console.WriteLine($"Getdiyimiz yol: {km} km. Qalan yanacaq: {CurrentFuel} litr. Ümumi yürüş: {Mileage + km} km.");
            }
            else
            {
                Console.WriteLine("Masinda seyahete yetecek qeder benzin yoxdur.");
            }
        }
    }
    


}

