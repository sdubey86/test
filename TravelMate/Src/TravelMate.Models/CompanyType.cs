using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the companytype table.
	/// </summary>
	[Table("companytype")]
	public partial class Companytype
	{
		[Key]
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual IEnumerable<Company> Companies { get; set; }
	}
}