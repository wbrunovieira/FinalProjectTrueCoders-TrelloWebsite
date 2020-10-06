using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Dapper;

namespace FinalProjectTrelloWebsite.Models
{
    public class ProductRepository : IProductRepository
    {

        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return _conn.Query<Product>("Select * from Product;");
        //}
    }
}
