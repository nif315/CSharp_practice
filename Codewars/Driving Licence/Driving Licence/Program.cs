using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_Licence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input driver's forename:");
            string forename = Console.ReadLine();
            Console.WriteLine("Input driver's middle name:");
            string middlename = Console.ReadLine();
            Console.WriteLine("Input driver's surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Input drivers birth date in format DD-MM-YYYY. Example: 01-Jan-2000");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Input drivers gender M or F");
            string gender = Console.ReadLine();

            while (surname.Length < 5)
            {
                surname += 9;
            }

            if (middlename == "")
            {
                middlename = "9";
            }
            else
            {
                middlename = middlename[0].ToString().ToUpper();
            }

            string decade = birthDate.Substring(birthDate.Length - 2);//decade[0] - The decade digit from the year of birth//decade[1] - The year digit from the year of birth
            string day = birthDate.Substring(0,2);
            string month = birthDate.Substring(3, 3).ToUpper();
            string nameInitial = forename[0].ToString().ToUpper();
            string arbitriaryDigit = "9";
            string checkDigits = "AA";

            switch(month)
            {
                case "JAN":
                    month = "01";
                    break;
                case "FEB":
                    month = "02";
                    break;
                case "MAR":
                    month = "03";
                    break;
                case "APR":
                    month = "04";
                    break;
                case "MAY":
                    month = "05";
                    break;
                case "JUN":
                    month = "06";
                    break;
                case "JUL":
                    month = "07";
                    break;
                case "AUG":
                    month = "08";
                    break;
                case "SEP":
                    month = "09";
                    break;
                case "OCT":
                    month = "10";
                    break;
                case "NOV":
                    month = "11";
                    break;
                case "DEC":
                    month = "12";
                    break;
                default: Console.WriteLine("You did not input the month");
                    break;
            }

            gender.ToUpper();
            if (gender == "F")
            {
                month = (int.Parse(month) + 50).ToString();
            }

            List<string> data = new List<string>();
            data.Add(surname.ToUpper());
            data.Add(decade[0].ToString());
            data.Add(month);
            data.Add(decade[1].ToString());
            data.Add(nameInitial);
            data.Add(middlename);
            data.Add(arbitriaryDigit);
            data.Add(checkDigits);

            Console.WriteLine(string.Join("",data));
            Console.ReadKey();
        }
    }
}
/*
The UK driving number is made up from the personal details of the driver. The individual letters and digits can be code using the below information
1–5: The first five characters of the surname (padded with 9s if less than 5 characters)

6: The decade digit from the year of birth (e.g. for 1987 it would be 8)

7–8: The month of birth (7th character incremented by 5 if driver is female i.e. 51–62 instead of 01–12)

9–10: The date within the month of birth

11: The year digit from the year of birth (e.g. for 1987 it would be 7)

12–13: The first two initials of the first name and middle name, padded with a 9 if no middle name

14: Arbitrary digit – usually 9, but decremented to differentiate drivers with the first 13 characters in common. We will always use 9

15–16: Two computer check digits. We will always use "AA"
 
Your task is to code a UK driving license number using an Array of data. The Array will look like

data = ["John","James","Smith","01-Jan-2000","M"];
Where the elements are as follows

0 = Forename

1 = Middle Name (if any)

2 = Surname

3 = Date of Birth (In the format Day Month Year, this could include the full Month name or just shorthand ie September or Sep)

4 = M-Male or F-Female*/