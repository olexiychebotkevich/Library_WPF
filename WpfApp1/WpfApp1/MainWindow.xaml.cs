using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        Book book = new Book();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {

            Add_Book_Viev addb = new Add_Book_Viev();
            addb.ShowDialog();
            if(addb._book!=null)
            {
                book = addb._book;
                view.Items.Add(book);
            }

        }

        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void ListView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ReaderView rw = new ReaderView(book.filePuth);
        }
    }
}
