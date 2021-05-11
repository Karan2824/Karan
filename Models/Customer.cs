using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karan.Models
{
    public class Customer
    {

        //primary key
        public int Id { get; set; }
        //First name of the customer
        public string FirstName { get; set; }
        //Last name of the customer
        public string Lastname { get; set; }
        //Bookname
        public string Bookname { get; set; }
        //Add Icollection 
        public ICollection<Author> Authors { get; set; }
        //Add Icollection
        public ICollection<Book> Books { get; set; }
    }
}
