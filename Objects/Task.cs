using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Objects
{
    class Task : INotifyPropertyChanged
    {
        public Task(String taskName, DateTime time, Boolean completed)
        {
            Name = taskName;
            Date = time;
            Completed = completed;
        }

        private string _Name;
        private DateTime _Date;
        private Boolean _Completed;

        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
                OnPropertyChanged("Date");
            }
        }

        public Boolean Completed
        {
            get
            {
                return _Completed;
            }
            set
            {
                _Completed = value;
                OnPropertyChanged("Completed");
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
