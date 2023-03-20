using System;
using System.Collections.Generic;
using StudentControl.Services.Person.PersonServices.Models;

namespace StudentControl.PersonServices.Models
{
    public class Student : Person
    {
        /// <summary>
        /// Fecha de registro
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// Lugar de nacimiento
        /// </summary>
        public string? BirthPlace { get; set; }

        /// <summary>
        /// Fecha de nacimiento
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Direccion
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Lugar de estudio o de trabajo
        /// </summary>
        public string? SchoolOrWorkPlace { get; set; }

        /// <summary>
        /// Cargo o curso
        /// </summary>
        public string? ClassOrJobPosition { get; set; }

        /// <summary>
        /// Representantes
        /// </summary>
        public List<Person>? Tutors { get; set; }

        /// <summary>
        /// Datos medicos del alumno
        /// </summary>
        public MedicalData? MedicalData { get; set; }

        /// <summary>
        /// Datos generales del alumno
        /// </summary>
        public GeneralData? GeneralData { get; set; }
    }
}

