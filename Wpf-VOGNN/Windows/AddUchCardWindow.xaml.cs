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

namespace Wpf_VOGNN.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddUchCardWindow.xaml
    /// </summary>
    public partial class AddUchCardWindow : Window
    {
        public AddUchCardWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                pd.PrintVisual(GridPrint, "Печать");
            }
        }
    }
}
