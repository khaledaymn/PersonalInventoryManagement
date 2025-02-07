using Microsoft.EntityFrameworkCore;
using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.DAL.DataBase;
using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PersonalInventoryManagement.BL.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository()
        {
            _context = new ApplicationDbContext();
        }


        #region Add

        public Category Add(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category), "Category cannot be null.");

            if (string.IsNullOrWhiteSpace(category.Name))
                throw new ArgumentException("Category name is required.", nameof(category));

            try
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return category;
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("An error occurred while saving the category.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        #endregion


        #region Update

        public Category Update(Category category)
        {
            try
            {
                var existingCategory = _context.Categories.Find(category.Id);
                if (existingCategory == null)
                    throw new KeyNotFoundException("Category not found.");

                existingCategory.Name = category.Name;
                existingCategory.ImageURL = category.ImageURL;
                _context.SaveChanges();
                return existingCategory;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating the category.", ex);
            }
        }



        #endregion


        #region Delete

        public bool Delete(int id)
        {
            try
            {
                var category = _context.Categories.Find(id);
                if (category == null)
                    throw new KeyNotFoundException("Category not found.");

                _context.Categories.Remove(category);
                _context.SaveChanges();
                return true; // Return true if deleted successfully
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                throw new ApplicationException("An error occurred while deleting the category.", ex);
            }
        }

        #endregion


        #region Get All

        public IEnumerable<Category> GetAll()
        {
            try
            {
                return _context.Categories;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving categories.", ex);
            }
        }

        #endregion


        #region Filter

        public IEnumerable<Category> Filter(Func<Category, bool> criteria)
        {
            try
            {
                return _context.Categories.Where(criteria).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while filtering categories.", ex);
            }
        }

        #endregion

       

    }
}
