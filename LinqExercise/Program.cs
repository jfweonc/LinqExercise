using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());
            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Average());
            //TODO: Order numbers in ascending order and print to the console
            var output1 = numbers.OrderBy(x => x).ToArray();
            foreach (var items in output1)
            {
                Console.WriteLine(items); 
            }
            //TODO: Order numbers in decsending order adn print to the console
            var output2 = numbers.OrderByDescending(x => x).ToArray();
            foreach (var items in output2)
            {
                Console.WriteLine(items);
            }
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Print to the console only the numbers greater than 6"); 
            var output3 = numbers.Where(x => x > 6).ToArray();
            foreach (var items in output3)
            {
                Console.WriteLine(items);
            }
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**"); 

            foreach (var items in output1)
            {
                if (items < 4) { Console.WriteLine(items); }
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 35; 
            numbers.OrderByDescending(x => x).ToArray(); 

            foreach(var items in numbers)
            {
                Console.WriteLine(items); 
            }
            // List of employees ****Do not remove this****


            var employees = CreateEmployees();
            Console.WriteLine(employees);
            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName."); 
            var outputArray1 = employees.Where(x => string.Equals(x.FirstName[0].ToString(),"C") || string.Equals(x.FirstName[0].ToString(), "S"));
            Console.WriteLine("foreach test");
            Console.WriteLine(employees[0].FirstName[0]);
            Console.WriteLine(employees[0].FirstName[0].ToString().Equals("C"));
            var outputArray2 = outputArray1.OrderBy(x => x).ToArray();
            foreach( var item in outputArray2)
            {
                Console.WriteLine(item.FullName);
            }



            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35

            //TODO: Add an employee to the end of the list without using employees.Add()


            Console.WriteLine();

            Console.ReadLine();
        }
        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
