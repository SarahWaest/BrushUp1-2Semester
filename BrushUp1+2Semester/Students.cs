using System;
using System.ComponentModel.DataAnnotations;

namespace BrushUp1_2Semester
{
    #region Gender
    public enum Gender
    {
        Female,
        Male
    }


    #endregion

    #region Student
    public class Students : Person
    {

        #region Instansfields
        /// <summary>
        /// Instansfields
        /// </summary>
        private int _semester;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for the Student Class
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="gender"></param>
        public Students(int semester, string name, string address, Gender gender)
        {
            Semester = semester;
            Name = name;
            Address = address;
            Gender = gender;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Semester has to be between 1 and 8, if it is under (1) or over(8) it will throw an ArgumentOutOfRangeExepeption.
        /// </summary>
        public int Semester
        {
            get => _semester;
            set
            {
                if (1 <= value && value <= 8) _semester = value;
                else throw new ArgumentOutOfRangeException("semester", value, "Semester is out of range");
            }
        }
        #endregion
        
    }
    #endregion

}