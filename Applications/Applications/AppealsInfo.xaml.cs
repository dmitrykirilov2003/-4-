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
    /// Логика взаимодействия для AppealsInfo.xaml
    /// </summary>
    public partial class AppealsInfo : Window
    {
        private Entities.Application application = null;
        int userId;
        public AppealsInfo()
        {
            InitializeComponent();
        }
        public AppealsInfo(Entities.Application info,int id)
        {
            InitializeComponent();
            userId = id;
            application = info;
            Title.Text = application.Title;
            var information = App.Context.Information_environment.Where(x => x.Id == application.IS).Select(x => x.Value).First();
            Information.Text = information;
            Purpose.Text = application.Purpose;
            var priority = App.Context.Priority.Where(x => x.Id == application.Priority).Select(x => x.Value).First();
            Priority.Text = priority;
            Date.Text = application.Date;
            var status = App.Context.Status.Where(x => x.Id == application.Status).Select(x => x.Value).First();
            var user_name = App.Context.User.Where(x => x.Id == application.IdExecutor).Select(x => x.Name).First();
            var user_surname = App.Context.User.Where(x => x.Id == application.IdExecutor).Select(x => x.Surname).First();
            var user_patronymic = App.Context.User.Where(x => x.Id == application.IdExecutor).Select(x => x.Patronymic).First();
            Method(status);
            if (status == "В разработке")
            {
                Status.Text = "В разработке у " + user_name + " " + user_surname + " " + user_patronymic;
            }
            else {
                Status.Text = "Статус: " + status;
            }
            var apl = App.Context.Application.Where(x => x.Id == application.Id).Select(x => x.Status).First();
            var SDA = App.Context.Status.Where(x => x.Id == apl).Select(x => x.Value).First();

            MethodStatus(SDA);
            if (SDA == "Готово" || SDA == "Невозможно выполнить")
            {
                Ocenka.Visibility = Visibility.Visible;
            }
            else
            {
                Ocenka.Visibility = Visibility.Hidden;
            }

            Loadeds();
            
        }
        void Loadeds()
        {

            CommentsLview.ItemsSource = App.Context.Comment.Where(x=>x.ApplicationId==application.Id).ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string comment = CommentTxt.Text;
            var _comment = new Entities.Comment
            {
                UserId = userId,
                ApplicationId = application.Id,
                Description = comment,
            };
            App.Context.Comment.Add(_comment);
            App.Context.SaveChanges();
            CommentTxt.Clear();
            Loadeds();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string estimation = estimationTxt.Text;
            application.Estimation= Convert.ToInt32(estimation)
                ;
            App.Context.SaveChanges();
        }
        public bool Method(string status)
        {
            if (status == "В разработке")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MethodStatus(string status)
        {
            if (status == "Готово" || status == "Невозможно выполнить")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        }
}
