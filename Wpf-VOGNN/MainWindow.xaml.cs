﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
            regin
        }

        public void OpenPage(pages pages)//функция открытия окон
        {
            if (pages == pages.login)//если форма открытия логин
            {
                frame.Navigate(new login(this));//открываем форму логин
            }
            else if (pages == pages.regin)
            {
                frame.Navigate(new regin(this));//открываем форму регистрации
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
            return dataTable;
        }
    }
}
