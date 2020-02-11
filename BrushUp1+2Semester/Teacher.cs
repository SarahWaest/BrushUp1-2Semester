using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUp1_2Semester
{
    #region Teacher
    class Teacher : Person
    {
        #region Instansfields

        /// <summary>
        /// Instansfields
        /// </summary>
        private double _salary;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        public Teacher(double salary, string name, string address, Gender gender)
        {
            Salary = salary;
            Name = name;
            Address = address;
            Gender = gender;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Salary has to be over or equal 0, if it is under 0 an ArgumentException will be thrown.
        /// </summary>
        public double Salary
        {
            get => _salary;
            set
            {
                if (value <= 0) throw new ArgumentException("Salary can't be under 0");
                _salary = value;
            }
        }
        #endregion
        
    }
    

#endregion
}