using System;
using PointsAndLines;
using OOP_practice;

class EntryPoint
{
    static void Main()
    {
        User user = new User("Admin",Race.Earthling);

        user.Password = 2;
        Console.WriteLine(user.Username + "\nUser ID is " + User.ID + "\nUser height is " + user.HEIGHT);
        user.ShowUsername();
    }
}