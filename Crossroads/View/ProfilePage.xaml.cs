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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Crossroads.View
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        Window loginWindow = new LoginWindow();
        public ProfilePage()
        {
            InitializeComponent();
        }

        




        private void OpenLoginWindow(object sender, RoutedEventArgs e)
        {
            
            // проверяем, открыто ли второе окно
            if (!loginWindow.IsVisible)
            {
                

                // если окно не открыто, открываем его
                loginWindow.Show();
            }
            else
            {
                // если окно открыто, активируем его
                loginWindow.Activate();
            }
        }
        
    }
}

