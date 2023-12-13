using System;
using System.Collections.Generic;

namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes
        private string workZone;
        private Vehicle _vehicle;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string workZone, List<string> languages = null):base(name, firstname, phonenumber, emailaddress, languages)
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
                return _vehicle; 
            } 
            set
            { 
                _vehicle = value; 
            }
        }


        public void TakeAVehicle(Vehicle vehicle)
        {
            if (Vehicle != vehicle)
            {
                Vehicle = vehicle;

                if (Vehicle == null)
                {
                    throw new NoVehicleAssignedException();
                }
            }
            else
            {
                throw new VehicleAlreadyAssignedException();
            }
           
        }

        public void ReleaseAVehicle()
        {
            if (_vehicle == null)
            {
                throw new NoVehicleAssignedException();
            }
            _vehicle = null;
        }
        #endregion public methods

        public class DriverException : Exception { }
        public class VehicleAlreadyAssignedException : DriverException { }
        public class NoVehicleAssignedException : DriverException { }
    }
}
