
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Applications
{
    public partial class Appeals : Window
    {
        int userId;
        public Appeals()
        {
            InitializeComponent();
            Update();
        }
        public Appeals(int id)
        {
            InitializeComponent();
            userId = id;

        }
        void Update()
        {
            LView.ItemsSource = App.Context.Application.Where(x => x.IdExecutor == null).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void MyApeals_Click(object sender, RoutedEventArgs e)
        {
            MyAppealsAdmin a = new MyAppealsAdmin(userId);
            this.Visibility = Visibility.Hidden;
            a.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void Give_Click(object sender, RoutedEventArgs e)
        {
            var currentproduct = (sender as Button).DataContext as Entities.Application;
            currentproduct.IdExecutor = userId;
            App.Context.SaveChanges();
            Update();
        }
    }
}
