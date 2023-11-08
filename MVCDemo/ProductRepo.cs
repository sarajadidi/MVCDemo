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
    }
}

