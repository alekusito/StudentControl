using System;

namespace StudentControl.PersonServices.Models
{
    public class Person
    {
        public int IndividualId { get; set; }

        public string? DocumentNumber { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string? SecondLastName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? CellPhoneNumber { get; set; }

        public string? MailAddress { get; set; }
    }
}
