using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Dapper;
using FinalProjectTrelloWebsite.Models;

namespace FinalProjectTrelloWebsite
{
    public class ProductRepository : IProductRepository
    {

        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE product SET Name = @name, Price = @price WHERE ProductID = @id",
                new { name = product.name, price = product.price, id = product.ProductID });
        }


        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCT WHERE PRODUCTID = @id", new { id = id });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("Select * from product;");
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO product (NAME, PRICE, CATEGORYID) VALUES (@name, @price, @categoryID);",
            new { name = productToInsert.name, price = productToInsert.price, categoryID = productToInsert.categoryID});
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM category;");
        }


        public Product AssignCategory()
        {
            var categoryList = GetCategories(); var product = new Product(); product.Categories = categoryList;

            return product;
        }

       public void DeleteProduct(Product product)
        {
       
            _conn.Execute("DELETE FROM Product WHERE productID = @id;", new { id = product.ProductID });
        }

        public IEnumerable<Product> SearchProduct(string newname)
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE NAME LIKE @name;",
                new { name = "%" + newname + "%" });
        }
    }


}

