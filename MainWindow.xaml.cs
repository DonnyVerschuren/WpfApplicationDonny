using Microsoft.EntityFrameworkCore;
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
using WpfApplication.Data;
using WpfApplication.Models;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private Database _db = new Database();
        public static DataGrid datagrid;
        public MainWindow()
        {
            InitializeComponent();
            
        }

       

        private void Load() // INLADEN GEGEVENS
        {

           // myDataGrid.ItemsSource = // Database invullen met juiste tabel 
           // datagrid = myDataGrid;
        }
        private void insertBtn_Click(object sender, RoutedEventArgs e)  // INSERT/ADD BUTTON
        { 
            InsertPage Ipage = new InsertPage();
            Ipage.ShowDialog();
        }
        private void updateBtn_Click(Object sender, RoutedEventArgs e) //UPDATE BUTTON
        {
            int id = (myDataGrid.SelectedItem as Item).Id;
            int author = (myDataGrid.SelectedItem as Author).Id;
            UpdatePage Upage = new UpdatePage(id,author);
            Upage.ShowDialog();

        }
        private void deleteBtn_Click(Object sender, RoutedEventArgs e) // DELETE BUTTON
        {
            int id = (myDataGrid.SelectedItem as Item).Id;
            var DeleteItem = _db.Items.Where(i => i.Id == id).Single();
            _db.Items.Remove(DeleteItem);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.Items.ToList();

            int author = (myDataGrid.SelectedItem as Author).Id;
            var DeleteAuthor = _db.Authors.Where(i => i.Id == id).Single();
            _db.Authors.Remove(DeleteAuthor);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.Authors.ToList();


        }
    }
}
