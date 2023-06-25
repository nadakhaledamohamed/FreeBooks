using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category
    {
        public Guid Id { get; set; } //used for Primary keys in database
        [Required(ErrorMessageResourceType = typeof(Resources.ResourceData),ErrorMessageResourceName ="CategoryName")]
        [MaxLength(20,ErrorMessageResourceType = typeof(Resources.ResourceData),ErrorMessageResourceName =("MaxLength"))]
        [MinLength(3, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MinLength"))]
        public string Name { get; set; }
        public string Description { get; set; }

        public int Currentstate { get; set; }
    }
}
