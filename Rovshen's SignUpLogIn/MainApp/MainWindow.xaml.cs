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

namespace MainApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> database = new Dictionary<string, string>();

        // private List<User> users = new List<User>();

        public MainWindow()
        {
            InitializeComponent();

            //var user = new User()
            //{
            //    Name = "Resad",
            //    Password = "12345"
            //};
            //users.Add(user);

            //users.Add(new User()
            //{
            //    Name = "Resad",
            //    Password = "12345"
            //});
        }

        private void SignIn(object sender, RoutedEventArgs e)
        {
            bool check = database.ContainsKey(Username.Text);

            if (check)
            {
                if (Password.Password == database[Username.Text]) displayStatus.Text = "Welcome!";
                else displayStatus.Text = "Invalid password!";
            }
            else displayStatus.Text = "Invalid username!";

            Username.Clear();
            Password.Clear();
        }

        private void SignUp(object sender, RoutedEventArgs e)
        {
            //foreach (var item in database.Keys)
            //{
            //    if (item == Username.Text) check = false;
            //}

            bool check = database.ContainsKey(Username.Text);

            if (!check)
            {
                database.Add(Username.Text, Password.Password);
                displayStatus.Text = "Signed up successfully!";
            }
            else displayStatus.Text = "This username already signed up";

            Username.Clear();
            Password.Clear();
        }
    }
}
