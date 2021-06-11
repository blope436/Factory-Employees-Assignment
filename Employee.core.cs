//Continuation of Employee.cs
using System;

namespace Employees 
{

    //Class EmployeeInfo will be derived from the Employee class, which is abstract
    class EmployeeInfo : Employee
       {

           
           //Variables will be set with {get; set;}
           //They will be used to store information entered by the program
            public string empName {get; set;}

            public int empID {get; set;}

            public string emphDate {get; set;}


            //Constructors
            public EmployeeInfo() {}

            public EmployeeInfo(string name, int id, string hDate) 
            {

                empName = name;

                empID = id;

                emphDate = hDate;

            }

            //DisplayStats method will be used to hold the Information of the employee
             new public virtual void DisplayStats()
            {

            Console.WriteLine("Employee Name: {0}",empName);
            Console.WriteLine("Employee ID: {0}",empID);
            Console.WriteLine("Employee Hiring Date: {0}",emphDate);
            
           
            
            
            }

            



       }

}