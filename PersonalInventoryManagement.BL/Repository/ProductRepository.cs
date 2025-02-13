using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PersonalInventoryManagement.BL.Helper;
using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.DAL.DataBase;
using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.BL.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly SqlConnection _con;
        public ProductRepository()
        {
            _context = new ApplicationDbContext();
            _con = DapperHelper.ConnectionString();
        }

        #region Add

        public Product Add(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");

            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return product;
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("An error occurred while saving the product.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion


        #region Update

        public Product Update(Product product)
        {
            try
            {
                var existingProduct = _context.Products.Find(product.Id);
                if (existingProduct == null)
                    throw new KeyNotFoundException("Product not found.");

                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.ExpireDate = product.ExpireDate;
                existingProduct.ImageURL = product.ImageURL;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.UserId = product.UserId;

                _context.SaveChanges();
                return existingProduct;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating the product.", ex);
            }
        }

        #endregion


        #region Delete

        public bool Delete(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product == null)
                    throw new KeyNotFoundException("Product not found.");

                _context.Products.Remove(product);
                _context.SaveChanges();
                return true; // Return true if deleted successfully
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while deleting the product.", ex);
            }
        }

        #endregion


        #region Get All

        public IEnumerable<Product> GetAll()
        {
            try
            {
                return _context.Products;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving products.", ex);
            }
        }

        #endregion


        #region Filter

        public IEnumerable<Product> Filter(Func<Product, bool> criteria)
        {
            try
            {
                return _context.Products.Where(criteria).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while filtering products.", ex);
            }
        }

        #endregion


        #region Count

        public int ProductsCount()
        {
            var count = _con.ExecuteScalar<int>("select count(*) from products");
            return count;
        }

        #endregion


        public int Good()
        {
            return _con.ExecuteScalar<int>("SELECT COUNT(*) FROM products WHERE ExpireDate >= @Date",
                new { Date = DateTime.Now.AddMonths(1) });
        }


        public int ExpireSoon()
        {
            return _con.ExecuteScalar<int>("SELECT COUNT(*) FROM products WHERE ExpireDate < @Date1 AND ExpireDate >= @Date2",
                new { Date1 = DateTime.Now.AddMonths(1), Date2 = DateTime.Now });
        }


        public int Expired()
        {
            return _con.ExecuteScalar<int>("SELECT COUNT(*) FROM products WHERE ExpireDate < @Date",
                new { Date = DateTime.Now });
        }



    }
}
