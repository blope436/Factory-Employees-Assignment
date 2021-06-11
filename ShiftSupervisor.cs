using System;
//The Employees class will be used to dervive it to the ShiftSuperVisor class
using Employees;

namespace ShiftSupervisors 

{
    //ShiftSupervisor class will be derived from the Employee class
     class ShiftSupervisor : Employee 
    {
        public double annualSalary {get; set;}

        public int belongingShift {get; set;}

        public double annualBonus {get; set;}

        public double fullAnnualSalary {get;set;}
        

    //Constructors
    public ShiftSupervisor()
    {

    }

        public ShiftSupervisor(double fullSalary, int fullBelongingShift, double fullAnnualBonus, double AnnualSalaryBonus) 
    {
        fullSalary = annualSalary;

        fullBelongingShift = belongingShift;

        fullAnnualBonus = annualBonus;
        
        AnnualSalaryBonus = fullAnnualSalary;
    }
    
    //DisplayStats method to display the results of ShiftSupervisor
    public override void DisplayStats()
        {
            //if statement is used to validate the belonging shift number
            //It must be between 1-3
             if (belongingShift > 3 || belongingShift < 1)
            {
            Console.WriteLine("Error! Belonging shift number must be between 1-3.\nShift must be 1 for day, 2 for night, and 3 for weekends.");
            Environment.Exit(0);
            }
            Console.WriteLine("Shift Supervisor");
            //fullAnnualSalary will add the ShiftSupervisor annualSalary and annualBonus
            fullAnnualSalary = annualSalary + annualBonus;
            Console.WriteLine("Annual Salary: ${0}",annualSalary);
            Console.WriteLine("Belonging Shift number: {0}",belongingShift);
            Console.WriteLine("Annual Bonus: ${0}",annualBonus);
            Console.WriteLine("Total Salary (With Bonus): ${0}",fullAnnualSalary);
        }



    }

    

        


    }


    

