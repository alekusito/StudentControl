using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentControlWebApp.Entities;

[Table("PERSON_MEDICAL_CONDITION")]
public class PersonMedicalCondition
{
    [Column("ID"), Key]
    public int Id { get; set; }

    [Column("INDIVIDUAL_ID"), Key]
    public int IndividualId { get; set; }

    [Column("DESCRIPTION")]
    public string? DESCRIPTION { get; set; }
}