using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWatch.Models.Models
{
	public class Category
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "Please enter category name.")]
		[StringLength(100, ErrorMessage = "The category name must be between 10 and 100 characters.", MinimumLength = 10)]
		[Display(Name = "Category Name")]
		public string CategoryName { get; set; }

		[Required(ErrorMessage = "Please enter category description.")]
		[StringLength(1000, ErrorMessage = "The category description must be between 20 and 1000 characters.", MinimumLength = 20)]
		[Display(Name = "Description")]
		public string Description { get; set; }

		public virtual ICollection<Watch> Watches{ get; set; }
	}
}
