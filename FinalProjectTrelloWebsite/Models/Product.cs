using System;
using System.Collections.Generic;

namespace FinalProjectTrelloWebsite.Models
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string imagePath { get; set; }
        public int categoryID { get; set; }
        public int companyID { get; set; }
        public int onsale { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Image { get; set; }


    }
}
