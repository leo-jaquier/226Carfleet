using System;
using System.Collections.Generic;

namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes
        private string workZone;
        private Vehicle vehicle;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string workZone, List<string> language):base(name, firstname, phonenumber, emailaddress, language)
        {
            this.workZone = workZone;
        }

        public string WorkZone
        {
            get
            {
                return workZone;
            }
        }

        public Vehicle Vehicle
        { 
            get 
            { 
                return vehicle; 
            } 
            set
            { 
                vehicle = value; 
            }
        }


        public void TakeAVehicle(Vehicle vehicle)
        {
            if (Vehicle != vehicle) 
            {
                Vehicle = vehicle;
            }
            else
            {
                throw new VehicleAlreadyAssigned();
            }
        }
        #endregion public methods

        public class DriverException : Exception { }
        public class VehicleAlreadyAssigned : DriverException { }
    }
}
