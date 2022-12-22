using System.Linq;
using System.Windows;
namespace Applications
{

    public partial class AddApeal : Window
    {
        int customerId;
        public AddApeal(int userId)
        {
            InitializeComponent();
            customerId = userId;
            var priority = App.Context.Priority.Select(p => p.Value).ToList();
            Priority_combox.ItemsSource = priority.Distinct();
            var information = App.Context.Information_environment.Select(p => p.Value).ToList();
            Is_combox.ItemsSource = information.Distinct();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var priorityList = App.Context.Priority.ToList();
            var informationList = App.Context.Information_environment.ToList();
            string title=Title_txt.Text;
            string purpose = Purpose_txt.Text;
            string description = Description_txt.Text;
            string date = Date_txt.Text;
            string priority = Priority_combox.Text;
            int priorityId = priorityList.Where(c => c.Value == priority).Select(p => p.Id).First();
            string information = Is_combox.Text;
            int informationId = informationList.Where(c=>c.Value == information).Select(p => p.Id).First();
            AddLoad(title,purpose,description,date,priorityId,informationId,customerId);
            this.Close();


        }
        public bool AddLoad(string title,string purpose, string description, string date, int priority, int information,int customer)
        {
            try
            {
                var Application = new Entities.Application
                {
                    Title = title,
                    Purpose = purpose,
                    Description = description,
                    Date = date,
                    Priority = priority,
                    Status = 6,
                    IS = information,
                    IdСustomer = customer,
                };
                App.Context.Application.Add(Application);
                App.Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
            
        }

    }
}
