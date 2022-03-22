using System;

namespace PracticeStuff
{
    public class Program
    {
        static void Main(string[] args)
        {

            // console print shit
            
            Console.WriteLine("YO");
            Console.WriteLine("Sup!");
            Console.Beep();           

            
            
            // variables shit
            int x;
            x = 123;

            int y = 321;

            int z = x + y;

            int age = 55;            
            double height = 300.5;
            bool alive = true;
            char symbol = '@';
            String name = "Kuronja";
            String userName = symbol + name;

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height);
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Your username is: " + userName);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x + y);
            Console.WriteLine(z);



            // constants shit

            const double pi = 3.14159;
            Console.WriteLine(pi);


            // type casting shit

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
            Console.WriteLine(d + " type is " + d.GetType());
            Console.WriteLine(f + " type is " + f.GetType());
            Console.WriteLine(h + " type is " + h.GetType());
            Console.WriteLine(i + " type is " + i.GetType());


            // user input shit

            Console.WriteLine("Write your name please: ");
            String nameInput = Console.ReadLine();

            Console.WriteLine("What's your age? ");
            int ageInput = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Hello " + nameInput);
            Console.WriteLine("You are " + ageInput + " years old.");


            // arithmetic shit

            int friends = 10;

            //friends = friends + 2;
            //friends += 2;
            //friends++

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2;
            //friends /= 2;

            int remainder = friends % 3;  //<-- remainder

            Console.WriteLine(remainder);



            //math shit

            double numberMath1 = 3.99;
            double numberMath2 = 5;
            

            double numberMathResult1 = Math.Pow(numberMath1, 2);
            double numberMathResult2 = Math.Sqrt(numberMath1);
            double numberMathResult3 = Math.Abs(numberMath1);
            double numberMathResult4 = Math.Round(numberMath1);
            double numberMathResult5 = Math.Ceiling(numberMath1);
            double numberMathResult6 = Math.Floor(numberMath1);
            double numberMathResult7 = Math.Max(numberMath1, numberMath2);

            Console.WriteLine(numberMathResult1);
            Console.WriteLine(numberMathResult2);
            Console.WriteLine(numberMathResult3);
            Console.WriteLine(numberMathResult4);
            Console.WriteLine(numberMathResult5);
            Console.WriteLine(numberMathResult6);
            Console.WriteLine(numberMathResult7);

            Console.WriteLine(friends);


            //rng shit

            Random random = new Random();

            int num1 = random.Next(1, 21);
            int num2 = random.Next(1, 21);
            int num3 = random.Next(1, 21);
            //double num=random.NextDouble();


            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);


            // hypotenuse program shit

            Console.WriteLine("Enter side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            double sideC = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            Console.WriteLine("Hypotenuse is: " + sideC);


            // string methods shit

            String fullName = "Kuro Kuric";
            String phoneNumber = "523-527-2216";


            fullName=fullName.ToUpper();
            Console.WriteLine(fullName);

            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumber);

            String userName2 = fullName.Insert(0, "Mr. ");
            Console.WriteLine(userName2);

            Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 4);
            String lastName = fullName.Substring(5, 5);

            Console.WriteLine(firstName);   
            Console.WriteLine(lastName);


            // if statements shit USING VARIABLES FROM user input shit

            if (age >100)
            {
                Console.WriteLine("You are too old to sign up.");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!" );
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up");
            }


            if (name == "")
            {
                Console.WriteLine("You have not entered your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }


            // switches shit

            Console.WriteLine("What day is it today? ");
            String day = Console.ReadLine();

            switch (day) 
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Party Time!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;
            }



            // logical operators shit

            Console.WriteLine("What's the temperature outside: (C) ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if(temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >=50)
            {
                Console.Write("Do not go outside!");
            }



            // while loop shit

            Console.Write("Enter your name: ");
            String nameLoop = Console.ReadLine();

            while (name == "") 
            {
                Console.Write("Enter your name: ");
                nameLoop = Console.ReadLine();
            }

            Console.WriteLine("Hello " + nameLoop);


            // for loops shit

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);             
            }

            for (int index = 10; index > 0; index--)
            { 
                Console.WriteLine(index);
            }
            Console.WriteLine("Happy New Year!!");


            // nested loops shit

            Console.WriteLine("How many rows? ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many collumns? ");
            int collumns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What symbol? ");
            String symbolRectangle = Console.ReadLine();

           for (int index = 0; index < rows; index++)
            {
                for (int index2 = 0; index2 < collumns; index2++)
                { 
                    Console.Write(symbolRectangle);
                }
                Console.WriteLine();
            }




            Console.ReadKey();


        }
    }
}
