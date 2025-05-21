using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	class Student : Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }
		public Student
		 (
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"Constractor:{this.GetHashCode()}");
		}
		public Student(Human human, string speciality, string group, double rating, double attendance) : base(human)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"Constractor:{this.GetHashCode()}");
		}
		~Student()
		{
			Console.WriteLine($"Destractor:{this.GetHashCode()}");
		}
		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");
		}
	}
}
