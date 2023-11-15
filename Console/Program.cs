using System.Diagnostics;

namespace Carfleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region private attributes
            string _registration = "VD 123 567";
            string _brand = "Mercedes-Benz";
            string _model = "Vito";
            string _chassisNumber = "SV30-0169266";
            Car _car;
            Truck _truck;
            _car = new Car("VD 123 567", "Mercedes-Benz", "Vito", "SV42-6666666");
            _truck = new Truck("FR 123 567","Renaud", "Vita", "SV99-9696969");
            #endregion private attributes



            DisplayCar(_car);
            DisplayTruck(_truck);
        }

        static private void DisplayCar(Car car)
        {
            Console.WriteLine(car.ToString());
        }

        static private void DisplayTruck(Truck truck)
        {
            Console.WriteLine(truck.ToString());
        }
    }
}