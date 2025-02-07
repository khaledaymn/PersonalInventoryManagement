using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.DAL.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(255)] 
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
