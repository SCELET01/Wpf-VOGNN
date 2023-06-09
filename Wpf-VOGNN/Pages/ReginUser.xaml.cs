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

namespace Wpf_VOGNN
{
    /// <summary>
    /// Логика взаимодействия для regin.xaml
    /// </summary>
    public partial class ReginUser : Page
    {
        public MainWindow mainWindow;
        public ReginUser(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.login);
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_login.Text.Length > 0) // проверяем логин
            {
                string[] dataLogin = TextBox_login.Text.Split('@'); // делим строку на две части
                if (dataLogin.Length == 2) // проверяем если у нас две части
                {
                    string[] data2Login = dataLogin[1].Split('.'); // делим вторую часть ещё на две части
                    if (data2Login.Length == 2)
                    {
                        if (password.Password.Length > 0) // проверяем пароль
                        {
                            if (password_Copy.Password.Length > 0) // проверяем второй пароль
                            {
                                if (password.Password == password_Copy.Password) // проверка на совпадение паролей
                                {
                                    if (TextBox_RKey.Text == "Q982-9AH8-3HZS-R3PV")
                                    {
                                        DataSet1TableAdapters.usersTableAdapter users = new DataSet1TableAdapters.usersTableAdapter();
                                        users.InsertUsers(TextBox_login.Text, password.Password);
                                        mainWindow.OpenPage(MainWindow.pages.login);
                                        MessageBox.Show("Пользователь зарегистрирован");
                                    }
                                    else MessageBox.Show("Введите регистрационный ключ");
                                }
                                else MessageBox.Show("Пароли не совподают");
                            }
                            else MessageBox.Show("Повторите пароль");
                        }
                        else MessageBox.Show("Укажите пароль");
                    }
                    else MessageBox.Show("Укажите логин в форме х@x.x");
                }
                else MessageBox.Show("Укажите логин в форме х@x.x");
            }
            else MessageBox.Show("Укажите логин");
        }
    }
}
