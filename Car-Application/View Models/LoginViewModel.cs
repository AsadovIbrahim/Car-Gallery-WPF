using CarDB.Contexts;
using CarDB.Entities;
using CarGallery.Commands;
using CarGallery.Models;
using Car_Application.Views;
using System.Windows;
using System.Windows.Controls;

namespace Car_Application.View_Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        private readonly Frame _frame;
        public Person Person { get; set; }

        public RelayCommand LoginCommand { get; }
        public RelayCommand signUpCommand { get; }


        public LoginViewModel(Frame navigationFrame)
        {
            LoginCommand = new RelayCommand(Login!);
            signUpCommand = new RelayCommand(SignUp!);
            _frame = navigationFrame;
        }

        public void Login(object parameter)
        {
            using(var context=new CarDBContext())
            {
                var admin = context.Admin!.FirstOrDefault(u => u.Username == Username && u.Password == Password);
                var user = context.Users!.FirstOrDefault(u => u.Username == Username && u.Password == Password);
                
                if (admin != null)
                {
                    _frame.Navigate(new AdminPage());
                }
                else if (user != null)
                {
                    _frame.Navigate(new UserPage());

                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
        }
        public void SignUp(object parameter)
        {
            _frame.Navigate(new SignUpPage());
        }
    }
}
