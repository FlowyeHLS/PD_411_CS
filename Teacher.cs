using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
    class Teacher:Human
    {
        public string Speciality { get; set; }
        public double Expirience { get; set; }
        public Teacher
            (
            string lastName, string firstName, int age,
            string speciality, double expirience
            ):base(lastName, firstName,age)
        {
            Speciality = speciality;
            Expirience = expirience;
            Console.WriteLine($"TConstructor: {this.GetHashCode()}");
        }
        ~Teacher()
        {
			Console.WriteLine($"TDestructor: {this.GetHashCode()}");
		}
        public void Info()
        {
            base.Info();
			Console.WriteLine($"{Speciality} {Expirience}");
        }


    }
}
