using System;
//Use the Production Workers class to call variables from it
using ProductionWorkers;

namespace Employees
{
    //Abstract class.
    abstract class Employee
    {

        //employeeName variable will hold the name of the employee
        string employeeName;
        //empID will hold the ID of the employee
        int empID;
        //hireDate will hold the date that the employee was hired
        string hireDate;

       
        // Constructors       
        public Employee()
        {

        }
        

        protected Employee(string name, int id, string date)
        {
            employeeName = name;

            empID = id;

            hireDate = date;

        }


        // DisplayStats() method to display the information for each class
        // Virtual is used so that I can use the same method for each class
        public virtual void DisplayStats()
        {
            Console.WriteLine("Employee Name: {0}",employeeName);
            Console.WriteLine("Employee ID: {0}",empID);
            Console.WriteLine("Employee Hiring Date: {0}",hireDate);
        }
        
        
        
            


    }

    
        

        
}