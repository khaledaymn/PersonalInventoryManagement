using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.DAL.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }

        [Required, StringLength(500)]
        public string ImageURL { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }

}
