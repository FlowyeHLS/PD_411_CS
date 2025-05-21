using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	class Program
	{
		static readonly string delimiter = "\n---------------------------------------------------\n";
		static void Main(string[] args)
		{
			Human human = new Human("Montana", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimiter);

			Student student = new Student("Pinkman", "Jessie", 23, "Chemisrty", "WW_40", 95, 66);
			student.Info();
			Console.WriteLine(delimiter);

			Teacher teacher = new Teacher("White", "Whalter", 50, "CHemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter);

			Human tommy = new Human("Verccety", "Tommy", 30);
			tommy.Info();
			Console.WriteLine(delimiter);

			Graduate mark = new Graduate("Kalivan", "Ivan", 27, "Chemistry", "WW_45", 95, 66, "TablicaMendeleeva", "W.Whalter");
			mark.Info();
			Console.WriteLine(delimiter);

			Specialist alesha = new Specialist("Popovich", "Alesha", 30, "Ximik", "WW_45", 100, 100, "Ximikov", " Ximikal_Technology");
			alesha.Info();
			Console.WriteLine(delimiter);
		}
	}
}
