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

namespace WpfApp1
{

    
    /// <summary>
    /// Interaction logic for ReaderView.xaml
    /// </summary>
    public partial class ReaderView : Window
    {
        string b;
        string text;
        public ReaderView(string book)
        {       
            InitializeComponent();
            b = book;
            using (System.IO.StreamReader sr = new System.IO.StreamReader(b, Encoding.Default))
            {
                TextBox1.Text = sr.ReadToEnd();
            }


        }


        


        
    }
}
