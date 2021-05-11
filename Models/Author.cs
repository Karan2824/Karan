using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karan.Models
{
    public class Author
    {
        public int Id { get; set; } //primary key
        //Name of the author
        public string Name { get; set; }
        //Name of the book
        public string Bookname { get; set; }
        //Customer ID
        public int CustomerID { get; set; }
        //Linkig author class to book class
        public Book Book { get; set; }
        //linking author class to customer class
        public Customer Customer { get; set; }
    }
}
