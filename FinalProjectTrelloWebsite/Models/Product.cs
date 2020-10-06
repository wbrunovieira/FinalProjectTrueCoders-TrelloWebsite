using System;
namespace FinalProjectTrelloWebsite.Models
{
    public class Product
    {
        public Product()
        {
        }

        public int productID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string imagePath { get; set; }
        public int categoryID { get; set; }
        public int companyID { get; set; }
        public int onsale { get; set; }

    }
}
