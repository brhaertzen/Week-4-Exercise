using System;

namespace Week_4_Exercise
{
	class Employee: Person
	{
		public DateTime startDate { get; set; }
		public string title { get; set; }
		public float salary { get; set; }
		private float bonusPay => salary * 0.25f;
		
		public Employee(string firstName, string lastName, DateTime startDate, string title, float salary)
		{
			//Person property
			this.firstName = firstName;
			this.lastName = lastName;

			this.startDate = startDate;
			this.title = title;
			this.salary = salary;

			//Lets us know it was properly created
			Console.WriteLine($"{FullName()} was created");
		}

		public void Working()
		{
			Console.WriteLine("I am working.");
		}

		public void Working(string project)
		{
			Console.WriteLine($"I am working on {project}");
		}

		public void ShowTitle()
		{
			Console.WriteLine($"My title is {title}.");
		}

		public void ShowSalary()
		{
			Console.WriteLine($"I have been working here since {startDate} and make ${salary}.");
		}

		public void ShowBonus()
		{
			if (Bonus())
				Console.WriteLine("We are eligible for a bonus!");
			else
				Console.WriteLine("We are NOT eligible for a bonus.");
		}

		public void BonusElligible()
		{
			if (Bonus())
				Console.WriteLine($"My bonus pay this year will be {bonusPay}!");
		}

		private bool Bonus()
		{
			DateTime currentDate = DateTime.Now;

			if (startDate.AddDays(180) < currentDate)			
				return true;					

			return false;
		}
	}
}
