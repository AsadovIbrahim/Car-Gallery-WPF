using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Models
{
    public class CarAdapter : INotifyPropertyChanged
    {
        private static int _Id;
        private string? _Brand;
        private string? _Model;
        private int _Year;
        private string ?_imagePath;

        public int Id;
        public string Brand
        {
            get { return _Brand!; }
            set { _Brand = value;
                OnPropertyChanged(nameof(Brand));
            }
        }

        public string Model
        {
            get { return _Model!; }
            set { _Model = value;
                OnPropertyChanged(nameof(Model)); 
            }
        }

        public int Year
        {
            get { return _Year!; }
            set { _Year = value;
                OnPropertyChanged(nameof(Year)); 
            }
        }
        public string ImagePath
        {
            get { return _imagePath!; }
            set
            {
                _imagePath = value;
                OnPropertyChanged(nameof(_imagePath));
            }
        }

        public CarAdapter(string brand,string model,int year,string imagePath)
        {
            Id = ++_Id;
            Brand = brand;
            Model = model;
            Year = year;
            ImagePath = imagePath;
        }
        public CarAdapter()
        {
            Id = ++_Id;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
