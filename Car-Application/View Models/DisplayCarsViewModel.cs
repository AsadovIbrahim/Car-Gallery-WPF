using CarDB.Contexts;
using CarDB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Car_Application.View_Models
{
    public class DisplayCarsViewModel
    {
        public List<Car> Cars { get; set; } = new();
        public string ?Brand { get; set; }
        public string ?Model { get; set; }
        public string ?Year { get; set; }
        public string ?ImagePath { get; set; }

        public void GetCars()
        {
            using(var context = new CarDBContext())
            {
                Cars=context.Cars!.ToList();
            }
        }
        public DisplayCarsViewModel()
        {
            GetCars();
        }

    }
}
