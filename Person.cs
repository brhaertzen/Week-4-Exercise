using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Exercise
{
	class Person
	{
		public string firstName { get; set; }
		public string lastName { get; set; }

		public string FullName()
		{
			return $"{firstName} {lastName}";
		}

		public void ShowFullName()
		{
			Console.WriteLine($"My name is {FullName()}.");
		}
	}
}
