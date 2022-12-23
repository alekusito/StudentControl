using System;

namespace StudentControl.Services.Person.PersonServices.Models
{
	public class MedicalData
	{
		/// <summary>
		/// Lesiones o fracturas?
		/// </summary>
		public bool HadInjuries { get; set; }

		/// <summary>
		/// Que lesiones o fracturas
		/// </summary>
		public string InjuryDescription { get; set; }

		/// <summary>
		/// Enfermedades respiratorias o cardiacas?
		/// </summary>
		public bool HasRespiratoryHeartDiseases { get; set; }

		/// <summary>
		/// Que enfermedades
		/// </summary>
		public string RespiratoryHeartDiseaseDescription { get; set; }

		/// <summary>
		/// Otras enfermedades?
		/// </summary>
		public bool HasOtherInjuriesDeseases { get; set; }

		/// <summary>
		/// Que enfermedades
		/// </summary>
		public string OtherInjuriesDeseasesDescription { get; set; }
    }
}

