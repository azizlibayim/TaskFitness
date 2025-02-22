// See https://aka.ms/new-console-template for more information
using TaskFitness;

class Program 
{
    static void Main ()
    {
        FitnessTracker device = new FitnessTracker ("Bayim's Fitness Tracker");

        device.AddUser("Mete");
        device.AddUser("Shahin");
        device.AddUser("Bayim");
        device.AddUser("Omar");

        device.TrackSteps(9783);
        device.TrackSteps(-50);

        device.PrintInfo();
        device.DeleteUser("Bayim");


        FitnessTracker newDevice = new FitTrackPro("Ramal's tracker");
        newDevice.AddUser("Ramal");
        newDevice.AddUser("Elbrus");
        newDevice.AddUser("Goshgar");
        newDevice.AddUser("Khazar");
        newDevice.AddUser("Baba");
        newDevice.AddUser("Volga");

        newDevice.TrackSteps(78000);
        newDevice.PrintInfo();

        newDevice.DeleteUser("Khazar");


        Activity running = new Running("Morning Run", 30);
        Activity cycling = new Cycling("Evening Ride", 50);
        
        running.CalculateCalories();
        running.PrintActivity();

        cycling.CalculateCalories();
        cycling.PrintActivity();
    }
}

