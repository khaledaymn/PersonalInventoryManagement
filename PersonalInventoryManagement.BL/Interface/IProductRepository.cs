using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.BL.Interface
{
    public interface IProductRepository
    {
        Product Add(Product category);
        Product Update(Product category);
        bool Delete(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> Filter(Func<Product, bool> criteria);
    }
}
