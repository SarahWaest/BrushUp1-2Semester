using System;

namespace BrushUp1_2Semester
{
    public class Person
    {
        #region Instansfields
        /// <summary>
        /// Instansfields
        /// </summary>
        private string _name;
        private string _address;
        #endregion

        #region Properties
        /// <summary>
        /// Gender property
        /// </summary>
        public Gender Gender { get; set; }


        /// <summary>
        /// Name has to be at least 2 characters or ArgumentException will be thrown if it is under 2 characters.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2) throw new ArgumentException("Name has to be at least 2 characters");
                _name = value;
            }
        }

        /// <summary>
        /// Address can't be null, ArgumentException will be thrown if it is null.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentException("Address can't be null");
                _address = value;
            }
        }
        #endregion

        
    }
}