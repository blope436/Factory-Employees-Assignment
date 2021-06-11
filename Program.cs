using System;
//Use the Employees class to get items from the class
using Employees;
//Use the PrductionWorkers class to get items from the class
using ProductionWorkers;
//Use the ShiftSupervisors class to get items from the class
using ShiftSupervisors;
//Use the TeamLeaders class to get items from the class
using TeamLeaders;

// Create employee variable of type EmployeeInfo - EmplyeeInfo class. Set Information
EmployeeInfo employee = new EmployeeInfo {empName = "Rob", empID = 1, emphDate = "1/20/2020"};
//Create if statement to seperate the employee ID's- ID 1 = Production Worker, ID 2 = Shift Supervisor
//ID 3 = TeamLeader
//ID 1 will be used to fill values of ProudctionWorker
//The if statement below will be used for validation of the Employee ID
//The ID must be between 1-3. ID 1 indicates a Production Worker, ID 2 indicates a Shift SuperVisor
//and ID 3 indicates a TeamLeader
if (employee.empID > 3 || employee.empID < 1)
{
    Console.WriteLine("Error! Employee ID must be between 1-3.");
    //Used so the program stops
    Environment.Exit(0);
}
if (employee.empID == 1)
{
    //create employee1 variable of type Production Worker
    ProductionWorker employee1 = new ProductionWorker {shiftNumber = 1,hourlyPayRate = 14.5, teamAssignment = "Lead"};
    //Display the information for employee
    employee.DisplayStats();
    employee1.DisplayStats();
    //If statement will identify the shift of the employee
    if (employee1.shiftNumber == 1)
    {
        Console.WriteLine("(Day Shift)");

    }
    if (employee1.shiftNumber == 2)
    {
        Console.WriteLine("(Night Shift)");

    }
    if (employee1.shiftNumber == 3)
    {
        Console.WriteLine("(Weekend Shift)");

    }
}
//Id 2 will be used to fill values of shift supervisor
if (employee.empID == 2)
{
    //Employee2 variable to hold values for ShiftSupervisor
    ShiftSupervisor employee2 = new ShiftSupervisor {annualBonus = 50,annualSalary = 40000, belongingShift = 3};
    //Display the information for employee
    employee.DisplayStats();
    employee2.DisplayStats();
    //If statement will identify the shift of the employee
    if (employee2.belongingShift == 1)
    {
        Console.WriteLine("(Day Shift)");

    }
    if (employee2.belongingShift == 2)
    {
        Console.WriteLine("(Night Shift)");

    }
    if (employee2.belongingShift == 3)
    {
        Console.WriteLine("(Weekend Shift)");

    }
    

}
//ID 3 will be used to fill values of TeamLeader
if (employee.empID == 3)
{
    //Employee3 variable will hold the values for TeamLeader
    TeamLeader employee3 = new TeamLeader {monthyBonus = 40, requiredTrainingHours = 44, trainingHours = 42};
    //Display the information for employee
    employee.DisplayStats();
    employee3.DisplayStats();
}














