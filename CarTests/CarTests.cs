using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment
        //(remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(1, 1, .1);
        }
        //TODO: constructor sets gasTankLevel properly
        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50, 4);
        }
        [TestMethod]
        public void TestInitialGasTank()
        {
            //Assert.AreEqual(10, test_car.GasTankLevel, .001);
            //Assert.IsFalse(test_car.GasTankLevel == 0);
            Assert.IsTrue(test_car.GasTankLevel == 10);
        }

        [TestMethod]
        public void TestNumberOfWheels()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50, 4);
            Assert.AreEqual(4, test_car.NumberOfWheels);
        }

            //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
            //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            test_car.Drive(50);
            Assert.AreEqual(55, test_car.GasTankLevel, .001);
        }
            //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }

    }
}
