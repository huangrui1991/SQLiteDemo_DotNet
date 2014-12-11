﻿using Microsoft.Win32;
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
using System.Data.SQLite;
using System.Data;

namespace WpfDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == true)
            {
                SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
                builder["Data Source"] = dlg.FileName;
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(builder.ConnectionString))                    
                    {
                        conn.Open();

                        //Get all tables in the database
                        DataTable table = conn.GetSchema("Tables");                         
                        TablesView.ItemsSource = table.AsEnumerable()
                            .Select(s => s.Field<string>(table.Columns[2].ToString()))
                            .ToArray<string>();
                    }
                }
                catch(SQLiteException msg)
                {
                    MessageBox.Show(msg.Message);
                }               
            }
        }
    }
}
