using System;

namespace week4class
{
    class Employee
    {
        public string firstname;
        public string lastname;

        public void printFullName()
        {
            Console.WriteLine(firstname + ' ' + lastname);
        }

        public class PartTimeEmployee : Employee
        {
            public new void printFullName()
        {
            Console.WriteLine(firstname + ' ' + lastname + "-- PartTime Employee");
        }
        }

         public class ContractEmployee : Employee
        {
        public new void printFullName()
        {
            Console.WriteLine(firstname + ' ' + lastname + " ---Contract Employee");
        }
        }
    }
}