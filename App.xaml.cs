using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WPFStudy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            SplashWelcome screen = new SplashWelcome();
            screen.Show();
            base.OnStartup(e);
            MainWindow main = new MainWindow();
            Thread.Sleep(1000);
            screen.Close();
        }
    }
}
