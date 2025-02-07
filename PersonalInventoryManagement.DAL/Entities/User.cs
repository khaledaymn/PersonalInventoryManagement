using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.DAL.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(255)] 
        public string Name { get; set; }

        [Required,EmailAddress] 
        public string Email { get; set; }

        [Required,MinLength(8)]
        public string Password { get; set; } 

        [Required,StringLength(50, MinimumLength = 3)]
        public string UserName { get; set; }
        public string ImageURL { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

}
