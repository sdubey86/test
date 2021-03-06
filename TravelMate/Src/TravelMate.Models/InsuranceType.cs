using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the insurancetype table.
	/// </summary>
	[Table("insurancetype")]
	public partial class Insurancetype
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual IEnumerable<Insurance> insurance { get; set; }
	}
}