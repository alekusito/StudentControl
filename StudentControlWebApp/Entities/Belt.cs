using System.ComponentModel.DataAnnotations.Schema;

namespace StudentControlWebApp.Entities;

[Table("BELT")]
public class Belt
{
    [Column("BELT_ID")]
    public int BeltId { get; set; }

    [Column("BELT_DESCRIPTION")]
    public string? BeltDescription {get; set;}
}
