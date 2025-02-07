using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.BL.Interface
{
    public interface ICategoryRepository
    {
        Category Add(Category category);
        Category Update(Category category);
        bool Delete(int id);
        IEnumerable<Category> GetAll();
        IEnumerable<Category> Filter(Func<Category, bool> criteria);
    }
}
