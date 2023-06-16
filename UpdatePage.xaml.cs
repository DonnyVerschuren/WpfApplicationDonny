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
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        private Database _db = new Database();

        int authorId = 0;
        int itemId = 0;


        public UpdatePage(int _userId, int _itemId)
        {
            InitializeComponent();
            authorId = _userId;
            itemId = _itemId;
        }
        public void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            Item updateItem = (from i in _db.Items where i.Id == itemId select i).Single();

            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Items.ToList();

            this.Hide();
        }

        private void updateBtn1_Click(object sender, RoutedEventArgs e)
        {
            Author updateAuthor = (from a in _db.Authors where a.Id == authorId select a).Single();

            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Authors.ToList();
            this.Hide();
        }


    }


}

      
