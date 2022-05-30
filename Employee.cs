using System;

namespace Week_4_Exercise
{
	class Employee
	{
		//Made these public so we could retrieve their title for our second working method
		public string firstName;
		public string lastName;
		public string fullName => firstName + " " + lastName;
		public string startDate;
		public string title;
		public string salary;
		
		public Employee(string _firstName, string _lastName, string _startDate, string _title, string _salary)
		{
			firstName = _firstName;
			lastName = _lastName;
			startDate = _startDate;
			title = _title;
			salary = _salary;

			//Lets us know it was properly created
			Console.WriteLine(fullName + " was created.");
		}

		//So we would know who is telling their info
		public void DeclareName()
		{
			Console.WriteLine("My name is " + fullName + ".");
		}

		public void Working()
		{
			Console.WriteLine("I am working.");
		}

		public void Working(string project)
		{
			Console.WriteLine("I am working on " + project);
		}

		public void ShowTitle()
		{
			Console.WriteLine("My title is " + title + ".");
		}

		public void ShowSalary()
		{
			Console.WriteLine("I have been working here since " + startDate + " and make " + salary + ".");
		}
	}
}
