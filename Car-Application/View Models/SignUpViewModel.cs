using Car_Application.Views;
using CarDB.Contexts;
using CarDB.Entities;
using CarGallery.Commands;
using System.Windows;
using System.Windows.Controls;

namespace CarGallery.View_Models
{
    public class SignUpViewModel
    {
        public User User { get; set; } = new User();

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public RelayCommand SignUpCommand { get; set; }

        private readonly Frame _frame;

        public SignUpViewModel(Frame navigationFrame)
        {
            _frame = navigationFrame;
            SignUpCommand = new RelayCommand(SignUp);
        }

        public void SignUp(object? param)
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) &&
                !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                User.Name = Name;
                User.Surname = Surname;
                User.Username = Username;
                User.Password = Password;

                using (var context = new CarDBContext())
                {
                    context.Users!.Add(User);
                    context.SaveChanges();
                    MessageBox.Show("User Added Successfully!");
                }
                _frame.Navigate(new LoginPage());
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
    }
}
