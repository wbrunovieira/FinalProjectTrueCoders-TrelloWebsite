﻿using System;
using FinalProjectTrelloWebsite.Models;
using System.Collections.Generic;

namespace FinalProjectTrelloWebsite
{
    public interface IProductRepository
    {

        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        
    }
}
