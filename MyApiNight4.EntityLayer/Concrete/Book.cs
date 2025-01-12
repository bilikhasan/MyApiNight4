using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight4.EntityLayer.Concrete
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal BookPrice { get; set; }
        public int BookPageCount { get; set; }
        public string BookImageUrl { get; set; }
    }
}
