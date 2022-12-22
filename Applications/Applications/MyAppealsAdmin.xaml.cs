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
using System.Windows.Shapes;

namespace Applications
{
    /// <summary>
    /// Логика взаимодействия для MyAppealsAdmin.xaml
    /// </summary>
    public partial class MyAppealsAdmin : Window
    {
        int userId;
        public MyAppealsAdmin()
        {
            InitializeComponent();
        }
        public MyAppealsAdmin(int id)
        {
            InitializeComponent();
            userId = id;



        }
        void Loadeds()
        {
            int roleId = (int)App.Context.Login.Where(x => x.UserId == userId).Select(c => c.Role).First();
            if (roleId == 1)
            {
                LView.ItemsSource = App.Context.Application.Where(x => x.IdExecutor == userId && x.Status!=5 && x.Status!=2).ToList();
            }
            if (roleId == 2)
            {
                LView.ItemsSource = App.Context.Application.Where(x => x.IdСustomer == userId).ToList();
            }



        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddApeal a = new AddApeal(userId);
            this.Visibility = Visibility.Hidden;
            a.ShowDialog();
            this.Visibility = Visibility.Visible;
            Loadeds();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Loadeds();
        }

        private void doneBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentproduct = (sender as Button).DataContext as Entities.Application;
            currentproduct.Status = 2;
            App.Context.SaveChanges();
            Loadeds();
        }

        private void impossibleBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentproduct = (sender as Button).DataContext as Entities.Application;
            currentproduct.Status = 5;
            App.Context.SaveChanges();
            Loadeds();
        }
    }
}

