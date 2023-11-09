using System;
using System.Data;
using Dapper;
using MVCDemo.Models;

namespace MVCDemo
{
	public class ProductRepo : IProductRepo
	{
		private readonly IDbConnection _conn;


		public ProductRepo(IDbConnection conn)
		{
			_conn = conn;
		}

        IEnumerable<Product> IProductRepo.GetAllProducts()
        {
			return _conn.Query<Product>("SELECT * FROM products;");
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id", new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
                new { name = product.Name, price = product.Price, id = product.ProductID });
        }
    }
}

