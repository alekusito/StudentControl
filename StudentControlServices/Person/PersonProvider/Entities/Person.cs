using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentControl.PersonServices.Entities
{
    [Table("PERSON")]
    public class Person
    {
        [Column("INDIVIDUAL_ID")]
        public int IndividualId { get; set; }

        [Column("DOCUMENT_NUMBER")]
        public string? DocumentNumber { get; set; }

        [Column("FIRST_NAME")]
        public string? FirstName { get; set; }

        [Column("MIDDLE_MANE")]
        public string? MiddleName { get; set; }

        [Column("LAST_NAME")]
        public string? LastName { get; set; }

        [Column("SECOND_LAST_NAME")]
        public string? SecondLastName { get; set; }

        [Column("BIRTH_DATE")]
        public DateTime BirthDate { get; set; }

        [Column("ADDRESS")]
        public string? Address { get; set; }

        [Column("PHONE_NUMBER")]
        public string? PhoneNumber { get; set; }

        [Column("CELL_PHONE_NUMBER")]
        public string? CellPhoneNumber { get; set; }

        [Column("MAIL_ADDRESS")]
        public string? MailAddress { get; set; }
    }
}
