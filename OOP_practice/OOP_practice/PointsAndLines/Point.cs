using OOP_practice;

namespace PointsAndLines
{
    class User
    {
        public Race race;
        public readonly int HEIGHT;
        public static int ID;

        private string username;
        private int password;

        //username property is read only
        public string Username
        {
            //read
            get { return "The username is " + username; }
        }

        //password property is write only and is hidden from the outside world
        public int Password
        {
            //write
            set
            {
                if (value >= 4 && value <= 6)
                {
                    password = value;
                }
                else
                {
                    System.Console.WriteLine("Password is not valid. It should be a number between 4 and 6");
                }
            }
        }

        public User()
        {
            ID++;
        }

        public User(string username, Race race)
        {
            this.username = username;
            this.race = race;
            ID++;

            if (this.race == Race.Earthling)
            {
                HEIGHT = 180;
            }
            else if(this.race == Race.Martian)
            {
                HEIGHT = 250;
            }
        }

        public void ShowUsername()
        {
            Utilities.ColorfulWriteline(username, System.ConsoleColor.Magenta);
        }
    }
}