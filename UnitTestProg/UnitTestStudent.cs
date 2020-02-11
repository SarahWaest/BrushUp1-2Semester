using System;
using BrushUp1_2Semester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProg
{
    [TestClass]
    public class UnitTestStudent
    {
        private Students _student = new Students(3, "Sarah", "Næstved", Gender.Female);

        //[TestInitialize]
        //public void Initialize()
        //{
        //    _student = new Students(3, "Sarah", "Næstved", Gender.Female);
        //}

        [TestMethod]
        public void TestConstructor()
        {
            Students student = new Students(3, "Sarah", "Næstved", Gender.Female);

            Assert.AreEqual("Sarah", student.Name);
            Assert.AreEqual("Næstved", student.Address);
            Assert.AreEqual(Gender.Female, student.Gender);
            Assert.AreEqual(3, student.Semester);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SemesterOutOfRangeHighTest()
        {
            //Arrange

            //Act
            _student.Semester = 9;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SemesterOutOfRangeLowTest()
        {
            //Arrange

            //Act
            _student.Semester = 0;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddressNullTest()
        {
            //Arrange

            //Act
            _student.Address = null;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShortNameTest()
        {
            //Arrange

            //Act
            _student.Name = "K";

            //Assert
        }
    }
}