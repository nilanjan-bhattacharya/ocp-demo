using System;

namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person) 
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName }.{ person.LastName}@acme.com";
            output.IsManager = person.TypeOfEmployee == EmployeeType.Manager;
            return output;
        }
    }
}
