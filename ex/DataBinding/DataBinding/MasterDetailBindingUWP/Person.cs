using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailBindingUWP
{
    public class PersonList : ObservableCollection<Person>
    { }

    public class Person : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("FullName");
            }
        }

        string firstname;
        public string FirstName
        {
            get { return this.firstname; }
            set
            {
                this.firstname = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string FullName
        {
            get { return $"{Name} {FirstName}"; }
        }
    }
}
