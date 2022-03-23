using System;

namespace hello_world
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

           
           
           // number guessing game shit

            Random d100 = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = d100.Next(min, max +1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again? (Y/N) ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");



            // rock paper scissors game shit

            Random randomFist = new Random();
            bool playAgain2 = true;
            String player;
            String computer;
            String response2;

            while (playAgain2)
            {
                player = "";
                computer = "";
                response2 = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();                    
                }

                switch (randomFist.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again? (Y/N)");
                response2 = Console.ReadLine();
                response2 = response2.ToUpper();
                if (response2 == "Y")
                {
                    playAgain2 = true;
                }
                else
                { 
                    playAgain2 = false;
                }
            }
            Console.WriteLine("Thanks for playing");


            // calculator program shit
            do
            {
                double calcNum1 = 0;
                double calcNum2 = 0;
                double calcResult = 0;

                Console.WriteLine("__________________");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("__________________");

                Console.Write("Enter number 1: ");
                calcNum1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number 2: ");
                calcNum2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+: Add");
                Console.WriteLine("\t-: Subtract");
                Console.WriteLine("\t*: Multiply");
                Console.WriteLine("\t/: Divide");
                Console.Write("Enter an option:");


                switch (Console.ReadLine())
                {
                    case "+":
                        calcResult = calcNum1 + calcNum2;
                        Console.WriteLine($"Your result: {calcNum1} + {num2} = " + calcResult);
                        break;
                    case "-":
                        calcResult = calcNum1 - calcNum2;
                        Console.WriteLine($"Your result: {calcNum1} - {num2} = " + calcResult);
                        break;
                    case "*":
                        calcResult = calcNum1 * calcNum2;
                        Console.WriteLine($"Your result: {calcNum1} * {num2} = " + calcResult);
                        break;
                    case "/":
                        calcResult = calcNum1 / calcNum2;
                        Console.WriteLine($"Your result: {calcNum1} / {num2} = " + calcResult);
                        break;
                    default:
                        Console.WriteLine("That was not a vaild option!");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");


            // arrays shit

            String[] cars = new string[4];

            // String[] cars = { "BMW", "Mustang", "Corvette" };

            cars[0] = "Tesla";
            cars[1] = "BMW";
            cars[2] = "Lada";
            cars[3] = "Mustang";

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]); 
            Console.WriteLine(cars[2]);

            for (int arrayIndex=0; arrayIndex < cars.Length; arrayIndex++)
            {
                Console.WriteLine(cars[arrayIndex]);
            }


            // for each loop shit USES ARRAYS SHIT 

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            // methods shit  METHOD IS OUTSIDE OF MAIN

            String birthdayName = "Kuuroonja";
            int birthdayAge = 443;

            singHappyBirthday(birthdayName, birthdayAge);
            singHappyBirthday(birthdayName, birthdayAge);
            singHappyBirthday(birthdayName, birthdayAge);

            // return keyword shit Multiply METHOD IS OUTSIDE OF MAIN

            double numberOne;
            double numberTwo;
            double returnKeywordNumber;

            Console.WriteLine("Enter number one: ");
            numberOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number two: ");
            numberTwo = Convert.ToDouble(Console.ReadLine());

            returnKeywordNumber = Multiply(numberOne, numberTwo);

            Console.WriteLine("Your result is: " + numberOne + " * " + numberTwo + " = " + returnKeywordNumber );


            // method overloading shit

            double overloadingShit;

            overloadingShit = Multiply(5, 4, 6);

            Console.WriteLine(overloadingShit);


            
            
            // params keyword shit (a method parameter that takes a variable number of arguments. The parameter type must be a single - dimensional array)
            // CheckOut METHOD OUTSIDE OF MAIN

            double total = CheckOut(34.5, 532.22, 5352.33, 7);

            Console.WriteLine(total);



            // exception shit

            int exceptionNumber1;
            int exceptionNumber2;
            double exceptionResult;

            try
            {
                Console.WriteLine("Enter number 1: ");
                exceptionNumber1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                exceptionNumber2 = Convert.ToInt32(Console.ReadLine());

                exceptionResult = exceptionNumber1 / exceptionNumber2;
                Console.WriteLine(exceptionResult);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch(DivideByZeroException excpetion)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }



            // conditional operator shit  used in conditional assignmenr if a condition is true/false
            // (condition) ? x : y ---> x=true y=false

            double temperature = 20;
            String message;

            if (temperature >= 15)
            {
                message = "It's warm outise!";
            }
            else
            {
                message = "It's cold outside!";
            }
            Console.WriteLine(message);

            message = (temperature >= 15) ? "It's warm outside" : "It's cold outside!";

            Console.WriteLine(message);


            // string interpolation shit ----> allows us to insert variables into a string literal
            //                                 precede a string literal with $       {} are placeholders

            String firstName2 = "Kuuuurooonjaaa";
            String lastName2 = "Kuric";
            int age12 = 42;

            Console.WriteLine("Hello " + firstName2 + " " + lastName2 + ".");
            Console.WriteLine("You are " + age12 + " years old.");

            Console.WriteLine($"Hello {firstName2} {lastName2}.");
            Console.WriteLine($"You are {age12} old.");



            // multidimensional arrays shit


            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camrry", "Rav4" };

            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, 
                                     { "Corvette", "Camaro", "Silverado" }, 
                                     { "Corolla", "Camrry", "Rav4" } 
                                   };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";

            foreach (String car in parkingLot)
            {
                Console.WriteLine(car);
            }

            for (int arrayShit = 0; arrayShit < parkingLot.GetLength(0); arrayShit++)    //GetLenght(0) 0 is first dimesion in parkingLot[x,y]  ie  x,  1 is second ie y
            {
                for (int arrayShit2 = 0; arrayShit2 < parkingLot.GetLength(1); arrayShit2++)
                {
                    Console.WriteLine(parkingLot[arrayShit, arrayShit2] + " ");
                }
            }


            // classes shit   Messages.cs in solution explorer

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();


            // objects shit  Human.cs in solution explorer


            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Ricky";
            human1.age = 42;
            human1.name = "Denzel";
            human1.age = 50;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();


            // constructors shit




            Console.ReadKey();
        }


       



        static void singHappyBirthday(String birthdayName, int birthdayAge)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayName);
            Console.WriteLine("You are " + birthdayAge + "years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
        static double Multiply(double numberOne, double numberTwo)
        {
            double numberThree = numberOne * numberTwo;
            return numberThree;
        }
        static double Multiply(double numberOne, double numberTwo, double numberOverload)
        {
            double numberThree = numberOne * numberTwo * numberOverload;
            return numberThree;
        }
        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
        
    }
}
