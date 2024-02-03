using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _description = "Welcome to the Breathing Activity\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);

        while (_duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("");

            Console.WriteLine("Now breathe out...");
            ShowCountDown(6);
            Thread.Sleep(1000);
            Console.WriteLine("");

            _duration -= 10;
        }

        DisplayEndingMessage();
    }
}
