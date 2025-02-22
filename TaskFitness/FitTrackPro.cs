using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFitness
{
    public class FitTrackPro : FitnessTracker
    {
        public FitTrackPro(string deviceName) : base(deviceName) 
        {
            BatteryLife = 48;
        }
           
            public int TotalSteps { get; private set; } = 0;
            private List<string> Users { get; set; } = new List<string>();


        public override void TrackSteps (int steps)
        {
            if (steps >= 1 && steps <= 100000)
            {
                TotalSteps += steps;
                Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}.");
            }
            else
            {
                Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 100,000.");
            }
        }

        public override void AddUser(string userName)
        {
            if (Users.Count >= 5)
            {
                Console.WriteLine("Cannot add more users. The limit of 5 users has been reached.");
            }
            else
            {
                Users.Add(userName);
                Console.WriteLine($"User {userName} has been added.");
            }
        }
        public override void DeleteUser(string userName)
        {
            if (Users.Remove(userName))
            {
                Console.WriteLine($"User {userName} has been deleted.");
            }
            else
            {
                Console.WriteLine("User not found. No user was deleted.");
            }
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"FitTrack Pro '{DeviceName}' has {BatteryLife} hours of battery life, {TotalSteps} total steps, and {Users.Count} users.");
        }

    }
}
