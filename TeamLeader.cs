using System;
//Use ProductionWorkers class to derive it to the TeamLeaders class
using ProductionWorkers;


namespace TeamLeaders
{
    //Teamleader class will be derived from the ProductionWorker class
    //The TeamLeader is sealed so that it cannot be inherited by another class
    sealed class TeamLeader : ProductionWorker
    {
        //Set variables with {get; set;}
        //They will be used to hold the values entered in the program
        public double monthyBonus {get; set;}
        public double requiredTrainingHours {get; set;}
        public double trainingHours {get; set;}

        public double remainingTrainingHours {get; set;}



    //Constructors
    public TeamLeader()
    {

    }

    public TeamLeader(double fullMonthlyBonus, double fullTrainingHours, double fullRequiredTrainingHours) 
    {
        fullMonthlyBonus = monthyBonus;

        fullRequiredTrainingHours = requiredTrainingHours;
        
        fullTrainingHours = trainingHours;

        
    }
    //DisplayStats() method to display the TeamLeader information
    public override void DisplayStats()
    {
        Console.WriteLine("Team Leader");       
        Console.WriteLine("Monthly Bonus: ${0}",monthyBonus);
        Console.WriteLine("Required Training Hours: {0}",requiredTrainingHours);
        Console.WriteLine("Training Hours attented: {0}",trainingHours);
        //remainingTrainingHours variable is used to return the result of required training hours
        remainingTrainingHours = requiredTrainingHours - trainingHours;
        //The if else statement will be used to verify if the TeamLeader has completed enough training hours    
        if (trainingHours < requiredTrainingHours)
        {
        Console.WriteLine("You have not met the required training hours, you need {0} more hours to go.",remainingTrainingHours);
            
        }
        else 
        {
            Console.WriteLine("You have met the required Traning hours, which are {0}",requiredTrainingHours);
        }
    }

    





    }
}