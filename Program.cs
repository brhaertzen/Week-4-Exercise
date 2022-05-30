using System;
using System.Collections.Generic;

namespace Week_4_Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>();

			Employee phillip = new Employee("Phillip", "Smith", "January 1st", "Water Boy", "$35,000");
			employees.Add(phillip);

			Employee ashley = new Employee("Ashley", "Johnson", "March 2nd", "CEO", "$150,000");
			employees.Add(ashley);

			Employee daniel = new Employee("Daniel", "Davis", "April 3rd", "Digital Artist", "$75,000");
			employees.Add(daniel);

			Employee sarah = new Employee("Sarah", "Taylor", "May 4th", "Accountant", "$90,000");
			employees.Add(sarah);

			Employee nicholas = new Employee("Nicholas", "Taylor", "June 5th", "Architect", "$110,000");
			employees.Add(nicholas);

			Console.WriteLine();
			foreach (Employee employee in employees)
			{
				employee.DeclareName();
				employee.Working();
				employee.Working("being the best " + employee.title + " in the world.");
				employee.ShowTitle();
				employee.ShowSalary();
				Console.WriteLine();
			}
		}
	}
}
