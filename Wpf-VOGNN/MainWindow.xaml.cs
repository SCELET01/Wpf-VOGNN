using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using Wpf_VOGNN.Pages;

namespace Wpf_VOGNN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(pages.login);

            //DataTable dt_user = Select("SELECT * FROM [dbo].[users]"); // получаем данные из таблицы    ||
            //                                                           //                               ||данные строки предназначенное для проверки логина и пароля из севера SQL
            //for (int i = 0; i < dt_user.Rows.Count; i++)//                                              ||
            //{ // перебираем данные                                                                      ||
            //    MessageBox.Show(dt_user.Rows[i][0] + "|" + dt_user.Rows[i][1]); // выводим данные       ||
            //}                                                                           //              ||
        }

        //список доступных окон
        public enum pages
        {
            login,
            regin,
            mainPage,
            spisok
        }

        public void OpenPage(pages pages)//функция открытия окон
        {
            if (pages == pages.login)//если форма открытия логин
            {
                frame.Navigate(new LoginUser(this));//открываем форму логин
            }
            else if (pages == pages.regin)
            {
                frame.Navigate(new ReginUser(this));//открываем форму регистрации
            }
            else if (pages == pages.mainPage)
            {
                frame.Navigate(new MainPage(this));
            }
            else if (pages == pages.spisok) 
            {
                frame.Navigate(new Spisok(this));
            }

        }

        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=(LocalDb)\\VOG.NN;Trusted_Connection=Yes;DataBase=VOG.NN;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        private void frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}
