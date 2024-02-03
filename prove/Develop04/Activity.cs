using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_description);

        Console.WriteLine("How long, in seconds, would you like for your session?");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Activity ended. Thank you for your session!");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }
    }
}
