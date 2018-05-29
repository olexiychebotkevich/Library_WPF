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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> genre = new List<string>();
        
        public MainWindow()
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

            

        }
    }
}
