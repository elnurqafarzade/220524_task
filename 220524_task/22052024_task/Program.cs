using _22052024_task;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Channels;
public class Program
{

    static void Main(string[] args)
    {
        Car car = new Car();
        car.Brand = "Chevrolet";
        car.Model = "Camaro";
        car.CurrentFuel = 60;
        car.Mileage = 100000;
        car.Fuelfor1km = 6;

        car.Drive(10);

    }
}