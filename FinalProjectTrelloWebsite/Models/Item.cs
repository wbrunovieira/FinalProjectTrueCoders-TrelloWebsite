using System;
namespace FinalProjectTrelloWebsite.Models
{
    public class Item
    {

        private Product pr = new Product();

        public Product Pr
        {
            get { return pr; }
            set { pr = value; }
        }
        private int quantity;

        public Item()
        {

        }

        public Item(Product product, int quantity)
        {
            this.pr = product;
            this.quantity = quantity;
        }

        public Product Product
        {
            get { return pr; }
            set { pr = value; }
            
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }

}