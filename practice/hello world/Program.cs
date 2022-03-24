using System;
using System.Collections.Generic;
using System.Threading;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            // console print shit
            
            Console.WriteLine("YO");
            Console.WriteLine("Sup!");
            Console.Beep();           

            
            /**
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
            */



            /**
            // constants shit

            const double pi = 3.14159;
            Console.WriteLine(pi);
            */



            /**
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
            */



            /**
            // user input shit

            Console.WriteLine("Write your name please: ");
            String nameInput = Console.ReadLine();

            Console.WriteLine("What's your age? ");
            int ageInput = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Hello " + nameInput);
            Console.WriteLine("You are " + ageInput + " years old.");
            */


            /**
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
            */



            /**
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
            */


            /**
            //rng shit

            Random random = new Random();

            int num1 = random.Next(1, 21);
            int num2 = random.Next(1, 21);
            int num3 = random.Next(1, 21);
            //double num=random.NextDouble();


            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            */


            /**
            // hypotenuse program shit

            Console.WriteLine("Enter side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            double sideC = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            Console.WriteLine("Hypotenuse is: " + sideC);
            */

            /**
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
            */


            /**
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
            */



            /**
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
            */


            /**
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
            */

            /**
            // while loop shit

            Console.Write("Enter your name: ");
            String nameLoop = Console.ReadLine();

            while (name == "") 
            {
                Console.Write("Enter your name: ");
                nameLoop = Console.ReadLine();
            }

            Console.WriteLine("Hello " + nameLoop);
            */


            /**
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
            */

            /**
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
           */

           
           /**
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
            */




            /**
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
            */



            /** calculator program shit
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
            */


            /**
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

            */

            /**
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
            */


            /**
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
                Console.WriteLine("Enter ONLY numbers PLEASE!" + exception);
            }
            catch(DivideByZeroException exception)
            {
                Console.WriteLine("You can't divide by zero!" + exception);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Something went wrong!" + exception);
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }
            */



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


            Human human1 = new Human("Ricky", 42);
            Human human2 = new Human("Denzel", 50);

            human1.name = "Ricky";
            human1.age = 42;
            human2.name = "Denzel";
            human2.age = 50;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();


            // constructors shit

            Human human3 = new Human("Ricky", 42);
            Human human4 = new Human("Denzel", 50);

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2020, "blue");

            car1.Drive();
            car2.Drive();


            // static shit

            Car car3 = new Car("Lada", "Niva", -442, "brown");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();


            // overloaded construcotrs shit

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");


            // inheritance shit

            RogueClass rogue = new RogueClass();

            rogue.Die();
            rogue.LongRest();

            PaladinClass paladin = new PaladinClass(); 

            paladin.LevelUp();
            Console.WriteLine(paladin.className + "" + paladin.speed);



            // abstract classes shit ---> modifier that indicates missing components or incomplete implementation
            //  abstract class DndClasses {} ------> can't do DndClasses dndclasses  = new DndClasses;


            // array of objects shit

            Car[] garage = new Car[4];

            Car car4 = new Car("Ford", "Mustang", 2022, "red");
            Car car5 = new Car("Chevy", "Corvette", 2020, "blue");
            Car car6 = new Car("Lada", "Njiva", 1990, "brown");
            Car car7 = new Car("Zetor", "Makeshift", 1970, "red");

            garage[0] = car4;
            garage[1] = car5;
            garage[2] = car6;
            garage[3] = car7;

            Console.WriteLine(garage[0]);
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);
            Console.WriteLine(garage[3].model);

            Car[] garage2 = { new Car("Ford", "Mustang", 2022, "red"), 
                              new Car("Chevy", "Corvette", 2020, "blue"), 
                              new Car("Lada", "Njiva", 1990, "brown"), 
                              new Car("Zetor", "Makeshift", 1970, "red") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);   
            }



            // objects as arguments

            Car car8 = new Car("Zetor", "4511", 1970, "red");
            

            Console.WriteLine(car8.make + " " + car8.model + " " + car8.color);
            Car car9 = Car.Copy(car8);

            Car.ChangeColor(car8, "gold");

            Console.WriteLine(car8.make + " " + car8.model + " " + car8.color);
            Console.WriteLine(car9.make + " " + car9.model + " " + car9.color);


            // method overriding shit ----->parent inherited method must be abstract, virtual or already overriden ---  used with ToString(), polymoprphism

            RogueClass  rogue2 = new RogueClass();
            PaladinClass paladin2 = new PaladinClass();
            BardClass bard2 = new BardClass();

            rogue2.Die();
            paladin2.Die();
            bard2.Die();


            // ToString() shit  -------> method overriden in Car class

            Car car10 = new Car("Daewoo", "Lanos", 2000, "silver");

            Console.WriteLine(car10.ToString());
            Console.WriteLine(car10);


            // polymorphism shit ----------> object can be identified b more than one type

            RogueClass rogue3 = new RogueClass();
            PaladinClass paladin3 = new PaladinClass();
            BardClass bard3 = new BardClass();

            DndClasses[] dndClasses = {rogue3, paladin3, bard3};

            foreach (DndClasses dndClass in dndClasses)
            {
                dndClass.Move();
            }


            // interface shit   ----------> Animals folder      a contract that all classes inheriting interface should follow,
            //                                                  but it only contains what a class should have,
            //                                                  and a class contains how it should do it
            Hawk hawk = new Hawk(); 
            Fish fish = new Fish();
            Rabbit rabbit = new Rabbit();
            rabbit.Flee();
            hawk.Hunt();
            fish.Hunt();
            fish.Flee();



            //List shit -------> using System.Collections.Generic;

            List<String> food = new List<String>();

            food.Add("chicken livers");
            food.Add("pizza");
            food.Add("hladetina");
            food.Add("chicken livers");
            food.Add("cheese");

           
            food.Remove("cheese");
            food.Insert(0, "sushi");
            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("pizza"));
            Console.WriteLine(food.LastIndexOf("chicken livers"));
            Console.WriteLine(food.Contains("fries"));
            food.Sort();
            food.Reverse();

            Console.WriteLine(food[0]);                      
            
                                                  //convert to array
            String[] foodArray = food.ToArray();

            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }

            food.Clear();

            //list of objects shit

            List<Player> players = new List<Player>();

            Player player1 = new Player("Gigachad");
            Player player2 = new Player("Sperg");
            Player player3 = new Player("n00b");
            Player player4 = new Player("Cheater");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(new Player("Šime"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);   //ToString() overriden in class
            }


            //getters and setters shit

            Bike bike = new Bike("Akrapovich", 80);
            bike.Speed = 2314234;

            Console.WriteLine(bike.Speed);


            // auto implemented properties shit    --------> Bike class

            Bike bike2 = new Bike("Akrapovich", 32);

            Console.WriteLine(bike2.Model);


            // enums shit   -----> it's used when you have values that you know will not change

            Console.WriteLine(Planets.Earth + " is a planet #" + (int)Planets.Earth);


            String planetName = PlanetRadius.Earth.ToString();
            int planetRadius = (int)PlanetRadius.Earth;
            double planetVolume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + planetName);
            Console.WriteLine("radius: " + planetRadius + "km");
            Console.WriteLine("volume: " + planetVolume + "km^3");


            // generics shit

            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.3, 2.4, 5.2 };
            String[] stringArray = { "one", "two", "three" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);


            // multithreading shit    ----------->  using System.Threading;

            Thread poglavica = Thread.CurrentThread;
            poglavica.Name = "Menetuch";
            Console.WriteLine(poglavica.Name);

            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));
            thread1.Start();
            thread2.Start();

            
            Console.WriteLine(poglavica.Name + " is complete!");


            Console.ReadKey();
        }

        public static void CountDown(String name)
        {
            for(int kurac = 10; kurac >= 0; kurac--)
            {
                Console.WriteLine("Timer #1 : " +kurac+ "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int kurac = 0; kurac <= 10; kurac++)
            {
                Console.WriteLine("Timer #2 : " + kurac + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
        public static void displayElements<DJENERIK>(DJENERIK[] kuronja)
        {
            foreach (DJENERIK item in kuronja)
            {
                Console.Write(item + " ");
            }
        }
       
        public static double Volume(PlanetRadius planetRadius)
        {
            double planetVolume = (4 / 3) * Math.PI * Math.Pow((int)planetRadius, 3);
            return planetVolume;  
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
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}
