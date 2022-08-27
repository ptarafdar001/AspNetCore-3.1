using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApplication.Models
{
    public class BookModel
    {
        //define all the data fields in forms of propartis
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
