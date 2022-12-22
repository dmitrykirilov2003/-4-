using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Applications
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities.ApplicationsEntities1 Context { get;} = new Entities.ApplicationsEntities1();

        public static Entities.Application CurrentApplication = null;
    }
}
