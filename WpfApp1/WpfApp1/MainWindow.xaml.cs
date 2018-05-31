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
using System.Windows.Forms;
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
        List<string> genre = new List<string>();
        public   Book book = new Book();
        ObservableCollection<Book> books =new ObservableCollection<Book>();
        ObservableCollection<Book> _books = new ObservableCollection<Book>();
        public MainWindow()
        {
            InitializeComponent();
            //this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("DictionaryClassic.xaml", UriKind.Relative) });
            genre.Add("novel");
            genre.Add("story");
            genre.Add("short story");
            genre.Add("epic");
            genre.Add("tale");
            genre.Add("fable");
            genre.Add("legend");
            genre.Add("novelette");
            view.ItemsSource = books;

            ComboBox1.Items.Add("All");
            ComboBox1.Items.Add("novel");
            ComboBox1.Items.Add("story");
            ComboBox1.Items.Add("short story");
            ComboBox1.Items.Add("epic");
            ComboBox1.Items.Add("tale");
            ComboBox1.Items.Add("fable");
            ComboBox1.Items.Add("legend");
            ComboBox1.Items.Add("novelette");


            ComboBox2.Items.Add("Classic");
            ComboBox2.Items.Add("Modern");






        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {

            Add_Book_Viev addb = new Add_Book_Viev(genre);
            addb.ShowDialog();
            if (addb._book != null)
            {
                book = addb._book;
                books.Add(book);
            }
           
           

        }

        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void ListView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ReaderView rw = new ReaderView(book.filePuth);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void view_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if(sender is Book)
            {
                Book b = view.SelectedItem as Book;

                ReaderView rw = new ReaderView(b.filePuth);
                rw.ShowDialog();

            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (view.SelectedItems.Count > 0)

            {
                if (_books.Count == 0)
                    books.RemoveAt(view.SelectedIndex);
                else
                {
                    books.RemoveAt(view.SelectedIndex);
                    _books.RemoveAt(view.SelectedIndex);
                }

            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
          
            
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (books.Count > 0)
            {

                _books.Clear();
                if (ComboBox1.SelectedItem.ToString() == "All")
                    view.ItemsSource = books;
                else
                {

                    foreach (Book i in books)
                    {
                        if (i.genre == ComboBox1.SelectedItem.ToString())
                            _books.Add(i);
                    }
                    view.ItemsSource = _books;


                }
            }
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Resources.Clear();
            if(ComboBox2.SelectedItem.ToString()== "Classic")
            this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("DictionaryClassic.xaml", UriKind.Relative) });
            else
            {
                this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("DictionaryModern.xaml", UriKind.Relative) });
            }

        }
    }
}
