using System;
using System.Collections.Generic;

namespace Week_4_Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>();

			employees.Add(new Employee("Phillip", "Smith", new DateTime(2018, 1, 2), "Water Boy", 35000f));
			employees.Add(new Employee("Ashley", "Johnson", new DateTime(2021, 12, 30), "CEO", 150000f));
			employees.Add(new Employee("Daniel", "Davis", new DateTime(2021, 5, 6), "Digital Artist", 75000f));
			employees.Add(new Employee("Sarah", "Taylor", new DateTime(2019, 11, 8), "Accountant", 90000f));
			employees.Add(new Employee("Nicholas", "Taylor", new DateTime(2022, 1, 1), "Architect", 110000f));

			Console.WriteLine();

			foreach (Employee employee in employees)
			{
				employee.ShowFullName();
				employee.ShowTitle();
				employee.Working($"being the best {employee.title} in the world.");				
				employee.ShowSalary();
				employee.ShowBonus();
				employee.BonusElligible();

				Console.WriteLine();
			}
		}
	}
}
