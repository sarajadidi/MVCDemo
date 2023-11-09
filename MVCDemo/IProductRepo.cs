﻿using System;
using MVCDemo.Models;

namespace MVCDemo
{
	public interface IProductRepo
	{
		public IEnumerable<Product> GetAllProducts();
		public Product GetProduct(int id);
		public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();

    }

}

