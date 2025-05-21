using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
    class Graduate:Student
    {
		public string ThesisTopic { get; set; }
		public string ScientificSupervisor { get; set; }

		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string thesisTopic, string scientificSupervisor
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			ThesisTopic = thesisTopic;
			ScientificSupervisor = scientificSupervisor;
			Console.WriteLine($"GConstructor:{this.GetHashCode()}");
		}

		~Graduate()
		{
			Console.WriteLine($"GDestractor:{this.GetHashCode()}");
		}
		public void Info()
		{
			base.Info();
			Console.WriteLine($"{ThesisTopic} {ScientificSupervisor}");
		}
	}
}
