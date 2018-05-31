using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   
    public class Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public string imgPuth { get; set; }
        public string filePuth;


        public Book(string name,string author,string genre,string imgputh,string fileputh)
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.imgPuth = imgputh;
            this.filePuth = fileputh;
            
        }


        public Book()
        {

        }




        



    }
}
