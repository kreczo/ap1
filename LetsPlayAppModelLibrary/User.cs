using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace LetsPlayAppModelLibrary
{
    class User
    {
        #region fields
        private string _Name;
        private string _City;
        #endregion //fields
        #region constructors
        public User(string name, string city)
        {
            _Name = name;
            _City = city;
        }
        public User() { }
        #endregion //constructors       
        #region properties
        public string Name { get { return _Name; }
            set
            {
                if (value != null)
                    _Name = value;
            }
    }
        public string City { get { return _City; }
            set
            {
                if (value != null)
                    _City = value;
            }
        }
        #endregion //properties        
    }
}
