using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
using _3pract.mysql1DataSetTableAdapters;

namespace _3pract
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        usersTableAdapter users_ = new usersTableAdapter();
        public Page1()
        {
            InitializeComponent();
            users.ItemsSource = users_.GetData();
        }

        private void btnpage1_Click(object sender, RoutedEventArgs e)
        {
            if (users.SelectedIndex != -1)
            {
                int id = Convert.ToInt32((users.SelectedItem as DataRowView).Row[0]);
                Debug.WriteLine(id);
                users_.DeleteQuery(id);
                users.ItemsSource = users_.GetData();
            }
            
        }
    }
}
