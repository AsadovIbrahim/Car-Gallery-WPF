using Car_Application.Views;
using CarGallery.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_Application.View_Models
{
    public class AdminViewModel
    {
        public RelayCommand ?AddCarCommand { get; set; }
        private readonly Frame _frame;
        
        public void AddCar(object? param)
        {
            _frame.Navigate(new AddCarPage());
        }
        public AdminViewModel(Frame navigationFrame)
        {
            AddCarCommand=new RelayCommand(AddCar);
            _frame = navigationFrame;
        }
    }

}
