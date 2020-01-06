using OCPLibrary;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>() 
            { 
                new PersonModel { FirstName = "Nilanjan", LastName = "Bhattacharya" },
                new PersonModel { FirstName = "Sue", LastName = "Storm", TypeOfEmployee = EmployeeType.Manager},
                new PersonModel { FirstName = "Nancy", LastName = "Drew" },
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                System.Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress }: {emp.IsManager}");
            }

            System.Console.ReadLine();
        }
    }
}
