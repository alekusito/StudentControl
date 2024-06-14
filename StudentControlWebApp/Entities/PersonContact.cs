using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentControlWebApp.Entities;

[Table("PERSON_CONTACT")]
public class PersonContact
{
    [Column("ID"), Key]
    public int Id { get; set; }

    [Column("PERSON_INDIVIDUAL_ID"), Key]
    public int PersonIndividualId { get; set; }

    [Column("CONTACT_INDIVIDUAL_ID")]
    public int ContactIndividualId { get; set; }
}