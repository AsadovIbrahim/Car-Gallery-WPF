using Car_Application.View_Models;
using CarDB.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Car_Application.Views
{
    
    public partial class DisplayCarsPage : Page
    {
        public DisplayCarsPage()
        {
            InitializeComponent();
            DataContext = new DisplayCarsViewModel();
        }
    }
}
