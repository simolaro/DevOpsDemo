using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthlyWage = 1234;
            int months = 12, bonus = 1000;

            var isActive = true;
            var rating = 99.25;
            //byte numberOfEmployees = 300;

            double ratePerHour = 12.34;
            int numberOfHourWorked = 165;
            long veryLongMonth = numberOfHourWorked;
            double d = 123456789.0;
            int x = (int)d;

            int intVeryLongMonth = (int)veryLongMonth;

            double currentMontWage = ratePerHour * numberOfHourWorked + bonus;
            Console.WriteLine(currentMontWage);

            ratePerHour += 3;

            if(currentMontWage > 2000) { Console.WriteLine("Top paid employee"); }

            int numberOfEmployees = 15;
            numberOfEmployees--;

            bool a;
            int b;

            int maxValue = int.MaxValue;
            int minValue = Int32.MinValue;

            char userSelection = 'a';
            char upperSelection = char.ToUpper(userSelection);

            bool isDigit = char.IsDigit(userSelection);
            bool isLetter = char.IsLetter(userSelection);

            DateTime hireDate = new DateTime(2021, 03, 28, 14, 30, 0);
            Console.WriteLine(hireDate);
            DateTime exitDate = new DateTime(2021, 12, 11, 14, 30, 0);
            //DateTime invalidDate = new DateTime(2021, 15, 11, 14, 30, 0);

            DateTime startDate = hireDate.AddDays(15);
            Console.WriteLine(startDate);

            DateTime currentDate = DateTime.Now;
            bool areWeInDst = currentDate.IsDaylightSavingTime();

            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(8, 35, 0);
            DateTime endHour = startHour.Add(workTime);

            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(endHour.ToShortTimeString());
            Console.WriteLine(startDate);

            string firstName = "Beth";
            string lastName = "Smith";

            System.String fullName = firstName+" "+lastName;
            string employeeIdentification = string.Concat(firstName, lastName);

            string empId =firstName.ToLower() + "-" + lastName.Trim().ToLower();
            int length = empId.Length;

            if (fullName.Contains("beth") || fullName.Contains("Beth")) { Console.WriteLine("It's Betahny!"); }
            string subString = fullName.Substring(1, 3);
            Console.WriteLine("Characters 2 to 4 of fullName are " + subString);

            string nameUsingInterpolation = $"{firstName}-{lastName}";

            string greeting = $"Hello, {firstName}";

            string noValueString = null;
            string s;

            s = firstName;

            var userName = "Veth";

            // Escape Characters
            string displayName = $"welcome! \n{firstName}\t{lastName}";

            Console.WriteLine(displayName);

            string invalieFP = "C:\\date\\empl.slxs";
            string mtl = "Baking the \"best pies\" eber";
            string verbatimFilePath = @"C:\date\el.slsx";

            // Comparing  2 strings
            string name1 = "Bethany";
            string name2 = "BETHANY";
            Console.WriteLine("Are both names equal? " + (name1 == name2));
            Console.WriteLine("Is name equal to Bethany? " + (name1 == "Bethany"));
            Console.WriteLine("Is name equal to BETHANY? " + name2.Equals("BETHANY"));
            Console.WriteLine("Is lower name equal to bethany? " + (name1.ToLower() == "bethany"));


            Console.ReadLine();
        }
    }
}
