using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentControl.ParametrizationServices.Entities
{
	[Table("Belt")]
	public class Belt
	{
		[Column("BELT_ID")]
		public int BeltId { get; set; }

		[Column("BELT_DESCRIPTION")]
		public string BeltDescrition { get; set; }
	}
}

