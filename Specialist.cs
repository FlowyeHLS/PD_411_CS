using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
    class Specialist:Student
    {
		public string Department { get; set; }  
		public string Qualification { get; set; }

		public Specialist
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string departament, string qualification
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Department = departament;
			Qualification = qualification;
			Console.WriteLine($"SConstructor:{this.GetHashCode()}");
		}

		~Specialist()
		{
			Console.WriteLine($"SDestractor:{this.GetHashCode()}");
		}

		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Department} {Qualification}");
		}
	}
}
