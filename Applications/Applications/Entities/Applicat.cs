using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Entities
{
    public partial class Application
    {
        public string priority { get
            {
                if (Priority1.Id==Priority)
                {
                   return Priority1.Value;
                }
                return "";
            } }
        public string information_environment
        {
            get
            {
                if(IS==Information_environment.Id)
                {
                    return Information_environment.Value;
                }
                return "";
            }
        }
        public string BorderColor
        {
            get
            {
                if (Status==Status1.Id)
                {
                    if(Status1.Value=="Готово")
                        return "Green";
                    if (Status1.Value == "Невозможно выполнить")
                        return "Red";
                    if (Status1.Value == "В разработке")
                        return "Gray";

                }
                    return "Gray";
            }
        }
        public string status
        {
            get
            {
                if (Status1.Value == "В разработке")
                {
                    if (IdExecutor == User1.Id)
                    {
                        return "В разработке у " + User1.Name + " " + User1.Surname + " " + User1.Patronymic;
                    }
                }
               
                return "Статус: " + Status1.Value;
               

            }

        }
    }
    
}
