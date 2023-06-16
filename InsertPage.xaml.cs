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
using WpfApplication.Data;
using WpfApplication.Models;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        private Database _db = new Database();
        public InsertPage()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            Author NewAuthor = new Author()
            {
                //FirstName = firstNametextBox.Text,
                //Lastname = lastNametextBox.Text
            };
            _db.Authors.Add(NewAuthor);
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Items;
            this.Hide();
        }

        private void insertBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Item NewItem = new Item()
            {
                //Authorname = authorNametextBox.Text,
                //Itemname = itemNametextBox.Text
            };

            _db.Items.Add(NewItem);
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Items;
            this.Hide();
        }
    }
}
