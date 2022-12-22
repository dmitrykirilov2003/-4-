using System.Linq;
using System.Windows;

namespace Applications
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool logins;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = App.Context.Login.ToList();
            string login = login_txt.Text;
            string password = password_txt.Text;
            Load(login,password);
            if (logins == true)
            {
                int id = (int)list.Where(c => c.Login1 == login && c.Password == password).Select(x => x.UserId).First();
                int rolId = (int)list.Where(x => x.UserId == id).Select(x => x.Role).First();
                if (rolId == 1)
                {

                    Appeals a = new Appeals(id);
                    this.Visibility = Visibility.Hidden;
                    a.ShowDialog();
                    this.Visibility = Visibility.Visible;
                }
                if (rolId == 2)
                {
                    MyAppeals a = new MyAppeals(id);
                    this.Visibility = Visibility.Hidden;
                    a.ShowDialog();
                    this.Visibility = Visibility.Visible;
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

        }
        public void Load(string login, string password)
        {
            var list = App.Context.Login.ToList();
            int count_login = list.Where(x => x.Login1 == login).Count();
            int count_password = list.Where(x => x.Password == password).Count();
            logins=Login(count_login, count_password);
            
        }
        public bool Login(int count_login,int count_password)
        {
            if (count_login > 0 && count_password > 0)
            {
                return true;
            }
            else if (count_login == 0 || count_password == 0)
            {

                return false;
            }
            return false;
        }

    }
}
