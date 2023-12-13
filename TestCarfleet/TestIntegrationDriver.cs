using NUnit.Framework;
using System.Collections.Generic;
using static Carfleet.Driver;

namespace Carfleet
{
    public class TestIntegrationDriver
    {
        #region private attributes
        private string _name = "Kiss";
        private string _firstname = "Norbert";
        private string _phonenumber = "+4398567985093";
        private string _emailaddress = "kiss.norbert@fia.com";
        private List<string> _languages = new List<string>();
        private string _workZone = "Spain";
        private Driver _driver;

        string _registration = "VD 123 567";
        string _brand = "Mercedes-Benz";
        string _model = "Vito";
        string _chassisNumber = "SV30-0169266";
        private Vehicle _vehicle;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _driver = new Driver(_name, _firstname, _phonenumber, _emailaddress, _workZone, _languages);
            _vehicle = new Vehicle(_registration, _brand, _model, _chassisNumber);
        }

        [Test]
        public void TakeAVehicle_AssignFristVehicle_VehicleAvailableForTheDriver()
        {
            //given

            //when
            _driver.TakeAVehicle(_vehicle);

            //then
            Assert.AreEqual(_vehicle.Registration, _driver.Vehicle.Registration);
        }

        [Test]
        public void TakeAVehicle_VehicleAlreadyAssigned_ThrowException()
        {
            //given
            _driver.TakeAVehicle(_vehicle);

            //when
            Assert.Throws<VehicleAlreadyAssignedException>(() => _driver.TakeAVehicle(_vehicle));

            //then
            //throws exception
        }

        [Test]
        public void ReleaseAVehicle_ReleaseVehicle_ReleaseSuccessful()
        {
            //given
            _driver.TakeAVehicle(_vehicle);

            //when
            _driver.ReleaseAVehicle();

            //then
            Assert.IsNull(_driver.Vehicle);
        }

        [Test]
        public void ReleaseAVehicle_NoVehicleAssigned_ThrowException()
        {
            //given

            //when
            Assert.Throws<NoVehicleAssignedException>(() => _driver.ReleaseAVehicle());

            //then
            //throws exception
        }
    }
}