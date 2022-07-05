using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exam2.Classes;
using Exam2.Pages;
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

namespace Exam2.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAutoriz.xaml
    /// </summary>
    public partial class PageAutoriz : Page
    {
        public PageAutoriz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((UserPasswordBox.Password.ToString() == "admin" && UserLogin.Text == "admin"))
            {
                MessageBox.Show("Добро пожаловать, " + UserLogin.Text);
                Administrator.MainFrame.Navigate(new PageAdmin());
            }
            else if((UserPasswordBox.Password.ToString() == "user" && UserLogin.Text == "user"))
            {
                MessageBox.Show("Добро пожаловать, " + UserLogin.Text);
                Administrator.MainFrame.Navigate(new PageCustomer());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");

            }
        }
    }
}
