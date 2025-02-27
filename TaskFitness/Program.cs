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


        FitnessTracker newDevice = new FitTrackPro("Goshgar's tracker");
        newDevice.AddUser("Goshgar");
        newDevice.AddUser("Elbrus");
        newDevice.AddUser("Kapaz");
        newDevice.AddUser("Shah");
        newDevice.AddUser("Baba");

        newDevice.TrackSteps(78000);
        newDevice.PrintInfo();

        Activity running = new Running("Morning Run", 30);
        Activity cycling = new Cycling("Evening Ride", 50);
        
        running.CalculateCalories();
        running.PrintActivity();

        cycling.CalculateCalories();
        cycling.PrintActivity();
    }
}

