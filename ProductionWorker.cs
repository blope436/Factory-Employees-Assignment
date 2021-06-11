using System;
//Use the Employees class derive it to the new class
using Employees;

namespace ProductionWorkers
{   

    // ProductionWorker class derived from the Employee class
    class ProductionWorker : Employee
    {
        // Variables will be set with {get; set}
        //They will hold information entered through the program
        public int shiftNumber {get; set;}


        public double hourlyPayRate {get; set;}

        public string teamAssignment {get; set;}

        // Constructors
        public ProductionWorker() {}
        public ProductionWorker(int shift, double payRate, string assignment)
        {

            shiftNumber = shift;

            hourlyPayRate = payRate;

            teamAssignment = assignment;

            

        }

        //DisplayStats() will hold display the values from production worker
        //override is used to set the same method with new variables
        public override void DisplayStats()
        {
            //if statement is used to validate the shift number
            //It must be between 1-3
             if (shiftNumber > 3 || shiftNumber < 1)
            {
            Console.WriteLine("Error! Shift number must be between 1-3.\nShift must be 1 for day, 2 for night, and 3 for weekends.");
            Environment.Exit(0);
            }
            Console.WriteLine("Production Worker");
            Console.WriteLine("Shift Number: {0}",shiftNumber);
            Console.WriteLine("Hourly Pay rate: ${0}",hourlyPayRate);
            Console.WriteLine("Team Assignment: {0}",teamAssignment);
           
        }

        




        
    }






}