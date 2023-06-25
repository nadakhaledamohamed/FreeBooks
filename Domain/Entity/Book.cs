using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Book
    {
        public Guid Id { get; set; }


        /// <summary>
        /// Name of book 
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = "BookName")]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MaxLength"))]
        [MinLength(3, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MinLength"))]
        public string Name { get; set; }
        /// <summary>
        /// Name of Author
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = "AuthorName")]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MaxLength"))]
        [MinLength(3, ErrorMessageResourceType = typeof(Resources.ResourceData), ErrorMessageResourceName = ("MinLength"))]
        public string Author { get; set; }
        public string ImageName { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public bool Publish { get; set; }
        public int CurrentState { get; set; }

        /// <summary>
        /// //
        /// </summary>
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category{ get; set; }
        public Guid SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory SubCategory { get; set; }

      

    }
}
