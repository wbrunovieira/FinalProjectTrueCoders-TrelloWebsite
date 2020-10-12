using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectTrelloWebsite.Models
{
    public class ProductModel
    {
        private List<Product> products;
        public ProductModel()
        {
            this.products = new List<Product>() {

            };
        }
    }
    public List<Product> findAll()
    {
        return this.products;
    }

    public Product find(string id)
    {
        return this.products.Single(p => p.Id.Equals(id));
    }

}
