using Car_Application.Views;
using CarDB.Contexts;
using CarDB.Entities;
using CarGallery.Commands;
using CarGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Car_Application.View_Models
{
    public class AddCarViewModel
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }
        public string? ImagePath { get; set; }

        private readonly Frame _frame;

        public Car Car { get; set; } = new();
        public RelayCommand? AddCarButtonCommand { get; set; }

        public void AddButton(object? param)
        {
            if (!string.IsNullOrEmpty(Brand) && !string.IsNullOrEmpty(Model)
                && !string.IsNullOrEmpty(Year) && !string.IsNullOrEmpty(ImagePath))
            {

                Car.Brand = Brand;
                Car.Model = Model;
                Car.Year = Year;
                Car.ImagePath = ImagePath;

                using (var context = new CarDBContext())
                {
                    context.Add(Car);
                    context.SaveChanges();
                    MessageBox.Show("Car Added Succesfully!");
                }

            }

            _frame.Navigate(new AdminPage());
        }
        public AddCarViewModel(Frame navigationFrame)
        {
            _frame = navigationFrame;
            AddCarButtonCommand = new RelayCommand(AddButton);
        }

    }
}
