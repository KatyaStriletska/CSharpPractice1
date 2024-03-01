using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Striletska01.Models
{
    class UserDate
    {
        #region Fields
        private DateTime _birthDate;
        private int _userAge;
        #endregion

        #region Properties
        public DateTime BirthDate
        { 
            get 
            {
                return _birthDate; 
            } 
            set 
            { 
                _birthDate = value; 
            }
        }
        public int UserAge
        {
            get
            {
                return _userAge;
            }
            set 
            {
                _userAge = value;
            }
        }
        #endregion
    }
}
