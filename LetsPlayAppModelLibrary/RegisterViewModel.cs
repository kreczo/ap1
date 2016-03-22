using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace LetsPlayAppModelLibrary
{
    class RegisterViewModel :INotifyPropertyChanged
    {
        #region fields
        private User _O = new User();                   
        public string txtName { get { return _O.Name; }
            set
            {
                if (value != null)
                {
                    _O.Name = value;
                    OnPropertyChanged("txtName");
                }
            }
        }
        public string txtCity { get { return _O.City; }
            set
            {
                if (value != null)
                {
                    _O.City = value;
                    OnPropertyChanged("txtCity");
                }
            }
        }
        #endregion //fields

        #region INotifyPropertyChanged members and others
        public void OnPropertyChanged(string PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion //inotify

        #region ICommand members and others
        private RelayCommand objCommand;
        //public RegisterViewModel()
        //{
        //    objCommand = new RelayCommand(this);
        //}
        public ICommand btnClick { get { return objCommand; } }
        #endregion //Icomand

    }
}
