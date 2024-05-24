using System.ComponentModel.DataAnnotations.Schema;

namespace StudentControlWebApp.Models;

public class Person
{    
    public int IndividualId { get; set; }

    public string? DocumentNumber { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? SecondLastName { get; set; }

    public DateTime BirthDate { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CellphoneNumber { get; set; }

    public string? MailAddress { get; set; }
}