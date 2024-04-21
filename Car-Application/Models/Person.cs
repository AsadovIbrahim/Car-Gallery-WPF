using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Models
{
    public class Person : INotifyPropertyChanged
    {
        private static int _Id;
        public int Id { get; set; }
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(_username));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(_password));
            }

        }
        public Person(string username, string password)
        {
            Id = ++_Id;
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return $"Id:{Id}\nUsername:{Username}\nPassword:{Password}";
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
