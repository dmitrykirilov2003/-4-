using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Entities
{
    public partial class Comment
    {
        public string Users { get
            {
                
                var user_name = App.Context.User.Where(x => x.Id == UserId).Select(x => x.Name).First();
                var user_surname = App.Context.User.Where(x => x.Id == UserId).Select(x => x.Surname).First();
                var user_patronymic = App.Context.User.Where(x => x.Id == UserId).Select(x => x.Patronymic).First();
                return user_name + " " + user_surname + " " + user_patronymic;
            } }
        public string horizontal { get
            {
                
                var adad= App.Context.Login.Where(x=>x.UserId== UserId).Select(x=>x.Role).First();
                if (adad == 1)
                {
                    return "Right";
                }
                if (adad == 2)
                {
                    return "Left";
                }
                return null;
            } }
        public string visible { get
            {
                var apl = App.Context.Application.Where(x => x.Id == ApplicationId).Select(x => x.Status).First();
                var status = App.Context.Status.Where(x => x.Id == apl).Select(x => x.Value).First();
                if(status=="Готово" || status=="Невозможно выполнить")
                {
                    return "Visible";
                }
                return "Hidden";
            } }
    }
}
