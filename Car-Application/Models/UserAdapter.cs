using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Models
{
    public class UserAdapter : Person, INotifyPropertyChanged
    {
        private string _name;
        private string _surname;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(_name));
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged(nameof(_surname));
            }
        }

        public CarAdapter Car { get; set; } = new();
        public UserAdapter(string name, string surname, string username, string password) : base(username, password)
        {
            Name = name;
            Surname = surname;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

