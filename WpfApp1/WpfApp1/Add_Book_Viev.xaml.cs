using Microsoft.Win32;
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
using System.Windows.Forms;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Add_Book_Viev.xaml
    /// </summary>
    
    public partial class Add_Book_Viev : Window
    {
        public Book _book;
        string image = null;
        string file = null;
        // ObservableCollection<string> genre = new ObservableCollection<string>();
        List<string> genre = new List<string>();

        public Add_Book_Viev()
        {
            InitializeComponent();
            genre.Add("novel");
            genre.Add("story");
            genre.Add("short story");
            genre.Add("epic");
            genre.Add("tale");
            genre.Add("fable");
            genre.Add("legend");
            genre.Add("novelette");

            Genre.ItemsSource = genre;
                

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "" || Author.Text=="" || Genre.SelectedIndex==-1 )
            {
                System.Windows.Forms.MessageBox.Show("Not all fields are full!!!");
            }
            else
            {
                _book = new Book(Name.Text, Author.Text, Genre.SelectedItem.ToString(), image, file);
                this.Close();
            }
        }

        private void Add_Image_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.ShowDialog();
            if (true == ofd.ShowDialog())
            {
                image = ofd.FileName;
            }
        }

        private void Add_File_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.ShowDialog();
            if(true == ofd.ShowDialog())
            {
                file = ofd.FileName;
            }
        }
    }
}
