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

namespace Wpf_VOGNN.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddUchetCard.xaml
    /// </summary>
    public partial class AddUchetCard : Page
    {
        public MainWindow mainWindow;
        public AddUchetCard(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void ButMainPage_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.mainPage);
        }

        private void ButSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
