using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace LetsPlayAppModelLibrary
{
    class RelayCommand :ICommand
    {
        #region fields
        private readonly Func<Boolean> _canExecute;
        private readonly Action _execute;
        //private RegisterViewModel obj;
        #endregion //fields

        #region constructors
        public RelayCommand(Action execute)
            :this(execute, null)
        {
        }
        //public RelayCommand(RegisterViewModel _obj)
        //{
        //    obj = _obj;
        //}
        public RelayCommand(Action execute, Func<Boolean> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
                _execute = execute;
                _canExecute = canExecute; 
            }
        }
        #endregion //constructors

        #region ICommand members
        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null) 
                    CommandManager.RequerySuggested += value; //can't attache "PresentationCore.ddl" to a class library
            }
            remove
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested -= value; //can't attache "PresentationCore.ddl" to a class library
            }
        }
        public Boolean CanExecute(Object param)
        {
            return _canExecute == null ? true : _canExecute();
        }
        public void Execute(Object param)
        {
            _execute();
            //User u = new User(obj.txtName.ToString(), obj.txtCity.ToString());
            
        }
        #endregion //ICommand members
    }
}
