using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopBD.UserControls
{
    public class Book
    {
        public string Id { get; set; }
        public string BookName { get; set; }
        public string Image { get; set; }
        public string AuthorName { get; set; }
        public string GenreName { get; set; }
        public string PublisherName { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }
    }
}
