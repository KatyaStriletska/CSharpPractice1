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
        #endregion
    }
}
