﻿using System;
using System.Collections.Generic;

namespace FinalProjectTrelloWebsite.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        //public Product GetProduct(int id);
        //public void UpdateProduct(Product product);
    }
}
