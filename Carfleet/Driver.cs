using System;
using System.Collections.Generic;

namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes
        private string workZone;
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
        #endregion public methods
    }
}
