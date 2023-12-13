using System;

namespace Carfleet
{
    public class Enterprise
    {
        #region private attributes
        private string name;
        private string street;
        private string city;
        private string phonenumber;
        private string emailaddress;
        #endregion private attributes

        #region public methods
        public Enterprise(string name, string street, string city, string phonenumber, string emailaddress)
        {
        }

        public void Add(Vehicle vehicleToAdd)
        {
            throw new NotImplementedException();
        }
        public void Add(Driver driverToAdd)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicleByChassisNumber(string chassisNumber)
        {
            throw new NotImplementedException();
        }
        public Driver GetDriverByEmailaddress(string emailaddress) 
        {
            throw new NotImplementedException(); 
        }
        public void AssignVehicleToDriver(string chassisNumber,string driverEmailaddress)
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
