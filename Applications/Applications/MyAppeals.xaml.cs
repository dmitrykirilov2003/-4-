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
    /// Логика взаимодействия для MyAppeals.xaml
    /// </summary>
    public partial class MyAppeals : Window
    {
       int userId;
        
        public MyAppeals()
        {
            InitializeComponent();
            
        }
        public MyAppeals(int id)
        {
            InitializeComponent();
            userId = id;

            
            
        }
        void Loadeds()
        {
            int roleId = (int)App.Context.Login.Where(x => x.UserId == userId).Select(c => c.Role).First();
            if (roleId == 1)
            {
                AddBtn.Visibility = Visibility.Hidden;
                LView.ItemsSource = App.Context.Application.Where(x => x.IdExecutor == userId).ToList();
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

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Loadeds();
        }

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            var appealsInfo = (sender as Button).DataContext as Entities.Application;
            this.Visibility = Visibility.Hidden;
            AppealsInfo a = new AppealsInfo(appealsInfo,userId);
            a.ShowDialog();
            this.Visibility = Visibility.Visible;

        }
    }
}
