using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        chatsTableAdapter chats = new chatsTableAdapter();
        public Page2()
        {
            InitializeComponent();
            chat.ItemsSource = chats.GetData();
        }

        private void btnpage2_Click(object sender, RoutedEventArgs e)
        {
            if (chat.SelectedIndex != -1)
            {
                int id = Convert.ToInt32((chat.SelectedItem as DataRowView).Row[0]);
                chats.DeleteQuery(id);
                chat.ItemsSource = chats.GetData();
            }
            
        }
    }
}
