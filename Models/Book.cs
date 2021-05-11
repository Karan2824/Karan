using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karan.Models
{
    public class Book
    {

        //primary key
        public int Id { get; set; }
        //Bookname
        public string Bookname { get; set; }
        //
        public string Plot { get; set; }
        //Release date of the book
        public DateTime Releaseyear { get; set; }
        //Price of the book
        public int Price { get; set; }
        //Add Icollection to add relation
        public ICollection<Author> Authors { get; set; }
    }
}
