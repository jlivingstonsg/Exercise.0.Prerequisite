using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;




namespace Exercise._0.Prerequisite
{



    class Program
    {






        static void Main()
        {

            //DateTimeOffset dateTimeObj = DateTime.Now;

            Console.WriteLine("Exercise 0. Prerequisite");
            Console.WriteLine("------------------------------------------------------------");
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.WriteLine("Question   number 111.   Writing to console.");
                    Console.WriteLine("Assignment number   1.   Print your first and last name in consol.");
                    Console.WriteLine("Assignment number   2.   Get date today, tomorrow and yesterday.");
                    Console.WriteLine("Question   number 222.   String manipulation.");
                    Console.WriteLine("Assignment number   3.   Ask for your first and last name and write to consol.");
                    Console.WriteLine("Assignment number   4.   Turn ..The quick fox Jumped Over the DOG..  to ..The brown fox jumped over the lazy dog..");
                    Console.WriteLine("Assignment number   5.   Turn ..Arrays are very common in programming, they look something like: [1,2,3,4,5].. ");
                    Console.WriteLine("                         to ..[1,4,5,6,7,8,9,10]..");
                    Console.WriteLine("Question   number 555.   Correct average.");
                    Console.WriteLine("Assignment number   6.   Ask for first and last number and output the biggest, smallest, difference (- ), ");
                    Console.WriteLine("                         sum(+), product(* ) and ratio( / ) between the two numbers.");
                    Console.WriteLine("Assignment number   7.   Calculate the area and volume of a circle respective sphere with the given radius.");
                    Console.WriteLine("Assignment number   8.   Input a decimal number. Then output square root of the number ");
                    Console.WriteLine("                         and the number raised to the power of 2 and 10..");
                    Console.WriteLine("Assignment number   9.   Restaurant order. ");
                    Console.WriteLine("Assignment number  10.   Choose between 3 different options. ");
                    Console.WriteLine("Assignment number  11.   Get going with iterations. ");
                    Console.WriteLine("Assignment number  12.   Multiplication table for 1 to 10. ");
                    Console.WriteLine("Assignment number  13.   Guess which number. ");
                    Console.WriteLine("Assignment number  14.   Sum and average of the numbers. ");

                    Console.WriteLine("Assignment number  18.   Get going with arrays. ");
                    Console.WriteLine("Assignment number  19.   Calculate change. ");

                    Console.WriteLine("Assignment number  21.   Min, max and average value. ");

                    Console.WriteLine("Assignment number  25.   Input two valid integer value and divide them. ");
                    Console.WriteLine("Assignment number  26.   Print out the folder path and create a new file. ");
                    Console.WriteLine("Assignment number  27.   Reading a file. ");
                    Console.WriteLine("Assignment number  28.   Writing to a file. ");

                   


                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.Write("Enter assignment number (or 0 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    // Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 111:
                            RunExerciseq1();
                            break;
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 222:
                            RunExerciseq2();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 555:
                            RunExerciseq5();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RunExerciseFourteen();
                            break;
                        case 15:
                            Console.WriteLine("15. (Optional) Not in use !");
                            break;
                        case 16:
                            Console.WriteLine("16. (Optional) Not in use !");
                            break;
                        case 17:
                            Console.WriteLine("17. (Optional) Not in use !");
                            break;
                        case 18:
                            RunExerciseEighteen();                            
                            break;
                        case 19:
                            RunExerciseNineteen();                            
                            break;
                        case 20:
                            Console.WriteLine("20. (Optional) Not in use !");
                            break;
                        case 21:
                            RunExercise21();                            
                            break;
                        case 22:
                            Console.WriteLine("20. (Optional) Not in use !");
                            break;
                        case 23:
                            Console.WriteLine("20. (Optional) Not in use !");
                            break;
                        case 24:
                            Console.WriteLine("20. (Optional) Not in use !");
                            break;
                        case 25:
                            RunExercise25();
                            break;
                        case 26:
                            RunExercise26();
                            break;
                        case 27:
                            RunExercise27();
                            break;
                       case 28:
                            RunExercise28();
                            break;
                       
                            



                        //---------------------------------------
                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number !");
                            break;
                    }
                    //Console.ResetColor();
                    Console.WriteLine("Hit any key to continuel");
                    Console.ReadKey();
                    Console.Clear();
                }// try 
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid key !");
                    Console.ResetColor();
                }

            }// while (keepAlive)





        }// static void Main(string[] args)


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private static void RunExerciseq1()
        {
            Console.WriteLine("Writing to console");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Hello");  //Byter rad
            Console.WriteLine("world!");  //Byter rad
            Console.Write("Hello");   //Byter inte rad
            Console.Write(" world!");//Byter inte rad
            Console.WriteLine("  ");
            Console.WriteLine("-----------------------");
        }//private static void RunExerciseq1()----------------------------------------------------------------------------------------------------------------------

        private static void RunExerciseOne()
        {
            // Console.WriteLine("Ange ditt Förnamn.");
            string firstname = "Magnus";
            //Console.WriteLine("Ange ditt efternamn.");
            string lastname = "Ivarsson";
            Console.WriteLine("Hello " + firstname + " " + lastname + "!  I’m glad to inform you that you are the test subject of my very first assignment!");
        }//private static void RunExerciseOne()----------------------------------------------------------------------------------------------------------------------


        private static void RunExerciseTwo()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "September", "October", "November", "December" };

            DateTime now = DateTime.Now;
            Console.WriteLine("Todays......date is {0} of {1} {2}", now.Day, months[now.Month - 1], now.Year);
            DateTime dt = DateTime.Now;
            DateTime dt1 = dt.AddDays(1);
            Console.WriteLine("Tomorrows...date is {0} of {1} {2}", dt1.Day, months[now.Month - 1], now.Year);
            DateTime dt2 = dt.AddDays(-2);
            Console.WriteLine("Yesterdays..date was {0} of {1} {2}", dt2.Day, months[now.Month - 1], now.Year);
        }//private static void RunExerciseTwo()--------------------------------------------------------------------------------------------------------------


        private static void RunExerciseq2()
        {
            String part = "if you're doing your";
            part += " best, \t you won't have any";                //  Added   += and removed  (part +)
            String quote = part + " time to worry about failure.";  // part add first and second part and  \t  is Tab in text 
            Console.WriteLine(quote);
            Console.WriteLine("-----------------------");
        }//private static void RunExerciseq2()-----------------------------------------------------------------------------------------------------------------------


        private static void RunExerciseThree()
        {
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine(firstname + " " + lastname);
        }//private static void RunExerciseThree()

        private static void RunExerciseFour()
        {
            String str4 = "The quick fox Jumped Over the DOG";
            //  The brown fox jumped over the lazy dog
            Console.WriteLine(str4);
            str4 = str4.Replace("quick", "brown");
            str4 = str4.Replace("Jumped Over", "jumped over");
            str4 = str4.Replace("DOG", "lazy dog");
            Console.WriteLine(str4);
        }//private static void RunExerciseFour()---------------------------------------------------------------------------------------------


        private static void RunExerciseFive()
        {
            String str5 = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            //  [1,4,5,6,7,8,9,10]
            Console.WriteLine(str5);
            str5 = str5.Replace("Arrays are very common in programming, they look something like: [", "[");
            str5 = str5.Replace(",2,3,", ",");
            str5 = str5.Replace("]", ",6,7,8,9,10]");
            Console.WriteLine(str5);
        }//private static void RunExerciseFive()----------------------------------------------------------------------------------------------



        private static void RunExerciseq5()
        {

            int a = 8;
            int b = 1;
            double average = (a + b) / (double)2;  // paranteser och  (double) i nämnaren
            Console.WriteLine(average);
            Console.WriteLine("-----------------------");
        }//private static void RunExerciseq5()------------------------------------------------------------------------------------------------------


        private static void RunExerciseSix()
        {
            Console.Write("Enter first number: ");
            double firstnumber6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double lastnumber6 = Convert.ToDouble(Console.ReadLine());
            //--------------------
            double biggest6;
            if (firstnumber6 > lastnumber6)
            { biggest6 = firstnumber6; } else { biggest6 = lastnumber6; }
            Console.WriteLine("Biggest: " + biggest6);
            //--------------------
            double smallest6;
            if (firstnumber6 < lastnumber6)
            { smallest6 = firstnumber6; } else { smallest6 = lastnumber6; }
            Console.WriteLine("Smallest: " + smallest6);
            //-------------------
            double diff6 = biggest6 - smallest6;
            Console.WriteLine("Difference (-): " + biggest6 + " - " + smallest6 + " = " + diff6);
            //----------------------
            double sum6 = firstnumber6 + lastnumber6;
            Console.WriteLine("Sum (+): " + biggest6 + " + " + smallest6 + " = " + sum6);
            //-----------------------
            double product6 = firstnumber6 * lastnumber6;
            Console.WriteLine("Product (*): " + biggest6 + " x " + smallest6 + " = " + product6);
            //----------------------
            if (lastnumber6 == 0)
            { Console.WriteLine("Second number can not be zero. Try again."); }
            else
            {
                double ratio6 = firstnumber6 / (double)lastnumber6;
                Console.WriteLine("Ratio (/) : " + firstnumber6 + " / " + lastnumber6 + " = " + ratio6);
            }           
        }//private static void RunExerciseSix()------------------------------------------------------------------------------------------------------


        private static void RunExerciseSeven()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            Console.Write("Enter radius and I will calculate area of circle and volume of sphere: ");
            double radius6 = Convert.ToDouble(Console.ReadLine());
            //--------------------
            double area6 = 3.141592 * radius6 * radius6;
            Console.WriteLine("Area of circle: " + area6.ToString("N", nfi));
            double volume6 = (4 * 3.141592 * radius6 * radius6 * radius6) / 3;
            Console.WriteLine("Volume of sphere: " + volume6.ToString("N", nfi));
        }//private static void RunExerciseSeven()


        private static void RunExerciseEight()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            Console.WriteLine("Input a decimal number. ");
            double tal8 = Convert.ToDouble(Console.ReadLine());
            //------------------------
            double tal8sqrt = Math.Sqrt(tal8);
            Console.WriteLine("Square root: " + tal8sqrt.ToString("N", nfi));
            //--------------------------------------
            double tal82 = Math.Pow(tal8, 2);
            Console.WriteLine("Raised to the power of 2: " + tal82.ToString("N", nfi));
            //-----------------------------------
            double tal810 = Math.Pow(tal8, 10);
            Console.WriteLine("Raised to the power of 10: " + tal810.ToString("N", nfi));

        }//private static void RunExerciseEight()-------------------------------------------------------------------------------------------

        private static void RunExerciseNine()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            Console.WriteLine("What is your first name. ");
            string firstname9 = Console.ReadLine();
            //------------------------
            Console.Write("Hello " + firstname9 + ". What year were you born?  ");
            var yearborn = int.Parse(Console.ReadLine() ?? "");
            //------------------------
            Console.Write("What month were you born (1 to 12)?  ");
            var monthborn = int.Parse(Console.ReadLine() ?? "");
            //------------------------
            Console.Write("What day were you born (1 to 31)?  ");
            var dayborn = int.Parse(Console.ReadLine() ?? "");
            //------------------------
            var birthday = new DateTime(yearborn, monthborn, dayborn);
            var age = DateTime.Today.Year - birthday.Year;
            if (birthday.Date > DateTime.Today.AddYears(-age)) age--;
            //--------------------------------------
            if (age > 18)
            {
                Console.Write("Do you want a beer? y/n  ");
                string beeryesno9 = Console.ReadLine();
                if (beeryesno9 == "y")
                {
                    Console.WriteLine("Serve beer.");
                }
                else
                {
                    Console.Write("Do you want a coke? y/n  ");
                    string cokeyesno9 = Console.ReadLine();
                    if (cokeyesno9 == "y")
                    {
                        Console.WriteLine("Serve coke.");
                    }
                }
            }
            else
            {
                Console.Write("Do you want a coke? y/n  ");
                string cokeyesno9 = Console.ReadLine();
                if (cokeyesno9 == "y")
                {
                    Console.WriteLine("Serve coke.");
                }
            }
        }//private static void RunExerciseNine()--------------------------------------------------------------------------------------------




        private static void RunExerciseTen()
        {
            
                try
                {
                    Console.WriteLine("Choose between 3 different options.  1.Calculate a division.  2.Exercise 4.  3.Toggle the foreground color. ");
                    Console.Write("or 0 to exit): ");

                    var assignmentChoice10 = int.Parse(Console.ReadLine() ?? "");
                    // Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice10)
                    {
                        case 1:
                            RunExercise10one();
                            break;
                        case 2:
                            RunExerciseFour();
                            break;
                        case 3:
                            RunExercise10Three();
                            break;
                        //-------------------------------
                        case 0:                            
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number !");
                            break;
                    }
                    //Console.ResetColor();
                    Console.WriteLine("Hit any key to continuel");
                    Console.ReadKey();
                    Console.Clear();
                }// try 
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    //Console.ResetColor();
                }

           

            static void RunExercise10one()
            {
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                nfi.NumberDecimalDigits = 4;
                Console.Write("Enter first number: ");
                double firstnumber6 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double lastnumber6 = Convert.ToDouble(Console.ReadLine());
                //----------------------
                if (lastnumber6 == 0)
                { Console.WriteLine("Second number can not be zero. Try again."); }
                else
                {
                    double ratio6 = firstnumber6 / (double)lastnumber6;
                    Console.WriteLine("Division (/) : " + firstnumber6 + " / " + lastnumber6 + " = " + ratio6.ToString("N", nfi));
                }
            }


            static void RunExercise10Three()
            {                
                if (Console.ForegroundColor == ConsoleColor.Gray)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("____________Ändrar färg______________ ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("____________Ändrar färg______________ ");
                }


            }//static void RunExerciseSix10one()


        }//private static void RunExerciseTen()--------------------------------------------------------------------------------------------------



        private static void RunExerciseEleven()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter a number above zero: ");
            int tal11 = Convert.ToInt32(Console.ReadLine());
            //------------------------
            if (tal11 > 0)
            {
                for (int i = 0; i < tal11 + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }


                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("------------------------------- ");
                Console.ResetColor();
                for (int i = 0; i < (tal11 + 1); i++)
                {
                    if ((tal11 - i) % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(tal11 - i);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(tal11 - i);
                        Console.ResetColor();
                    }

                }
            }
            else
            {
                Console.WriteLine("____________Not allowed integer !!!__________-- ");
                Console.ResetColor();

            }
           

        }//private static void RunExerciseEleven()---------------------------------------------------------------------------


        private static void RunExerciseTwelve()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }
        }//private static void RunExerciseTwelve()-----------------------------------------------------------------------


        private static void RunExerciseThirteen()
        {
            Random rnd13 = new Random();
            int rand613 = rnd13.Next(1, 501);
            Console.Write("Guess number between 1 och 500.  (Med facit.) ");
            double tal6113 = Convert.ToDouble(Console.ReadLine());
            int count6213 = 0;
            //--------------------------------
            while (tal6113 > 0 & tal6113 < 501)
            {
                if (tal6113 == rand613)
                {
                    count6213 += 1;
                    Console.WriteLine("Correct number on " + count6213 + " try.");                    
                }
                else
                {
                    count6213 += 1;
                    if (tal6113 > rand613)
                    {
                        Console.Write("Your guess was too big. Try again. ___ (Facit: " + rand613 + "): ");
                        
                    }
                    else
                    {
                        Console.Write("Your guess was too small. Try again. ___ (Facit: " + rand613 + "): ");
                    }
                    tal6113 = Convert.ToDouble(Console.ReadLine());
                }

            }

            if (tal6113 < 1 | tal6113 > 501)
            {
                Console.WriteLine("Wrong input: 1 - 500. Bye.");
            }
        }//private static void RunExerciseThirteen()---------------------------------------------------------------------------



        private static void RunExerciseFourteen()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            double number14 = 0;
            double sum14 = 0;
            double average14;
            double counter14 = -1;

            do
            {
                if (-1 != number14)
                {
                    counter14 += 1;
                    sum14 += number14;
                }
                Console.Write("Enter a number: ");
                number14 = Convert.ToDouble(Console.ReadLine());
                //--------------------                              
                average14 = sum14 / counter14;
            }
            while (-1 != number14);
            Console.WriteLine("Sum: " + sum14);                
            Console.WriteLine("Average: " + average14.ToString("N", nfi));                                  
        }//private static void RunExerciseFourteen()------------------------------------------------------------------



        private static void RunExerciseEighteen()
        {
            int Min = 55;
            int Max = 99;
            Random randNum = new Random();
            int[] test181 = new int[10];
            for (int i = 0; i < test181.Length; i++)
            {
                test181[i] = randNum.Next(Min, Max);
            }
            double[] test182 = new double[10];
            for (int i = 0; i < test182.Length; i++)
            {
                test182[i] = randNum.Next(Min, Max);
                test182[i] = 1 / test182[i];
            }
            foreach (int items181 in test181)
            {
                Console.WriteLine("Random int: " + items181);
            }
            Console.WriteLine("------------------");
            foreach (double items182 in test182)
            {
                Console.WriteLine("Random double: " + items182);
            }

        }//private static void RunExerciseEighteen()-----------------------------------------------------------------



        private static void RunExerciseNineteen()
        {
            Random rnd13 = new Random();
            int rand19 = rnd13.Next(1, 10001);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Money to pay: {0} kr.", rand19);
            Console.Write("Enter the sum you pay: ");
            int sum19 = Convert.ToInt32(Console.ReadLine());
            int change =  sum19 - rand19;
            Console.WriteLine("Calculated change: {0} kr.", change);
            Console.WriteLine("Coins distribution: ");
            List<int> amounts19 = new List<int>() { 1000,500, 100, 50, 20, 10, 5, 1 };
            int hundreds;
            int index19 = 0;
            foreach (var item19 in amounts19)
            {               
                hundreds = (int)(change / amounts19[index19]);
                Console.WriteLine("{0} coins = Quantity: {1} ", amounts19[index19], hundreds);
                change %= amounts19[index19];
                index19++;
                                   
            
            }

            Console.WriteLine("-------------------End--------------------- ");
            Console.ResetColor();

        }// private static void RunExerciseNineteen()--------------------------------------------------------------------------------------------



        private static void RunExercise21()
        {
            Console.WriteLine("Write some numbers separated with a comma sign like this and you get min, max and average value.  ");
            string array14 = (Console.ReadLine());
            int[] arr21 = Array.ConvertAll(array14.Split(','), int.Parse);

           
            Console.WriteLine("Lowest number  is {0}", arr21.Min());
            Console.WriteLine("Highest number is {0}", arr21.Max());
            Console.WriteLine("Average        is {0}", arr21.Average());
            Console.WriteLine("-------------------End--------------------- ");

           
        }// private static void RunExercise21()------------------------------------------------------------------------------------------




        private static void RunExercise25()
        {

            int int25;
            double div25;
            bool bool25 = false;
            do
            {

                
                try
                {
                    int tal125, tal225;
                    Console.Write(" Input two valid integer value and divide them. \n Write the first here:  ");
                    tal125 = Convert.ToInt32(Console.ReadLine());
                    double dtal125 = Convert.ToDouble(tal125);
                    Console.Write(" Write the second here: ");
                    tal225 = int.Parse(Console.ReadLine());
                    double dtal225 = Convert.ToDouble(tal225);

                    int25 = tal125 / tal225;
                    div25 = dtal125 / dtal225;

                    Console.WriteLine(" Divisionen   {0} / {1} =  {2} ", tal125, tal225, div25);
                    bool25 = true;
                    Console.WriteLine("-------------------End---------------------- ");
                }

                //Multiple Catch block to handle exception

                catch (DivideByZeroException dex)
                {
                    Console.WriteLine(" You can not use 0 as denominator in division. ");
                    Console.WriteLine(" More Details about Error: \n\n" + dex.ToString() + "\n\n");
                }

                catch (FormatException fex)
                {
                    Console.WriteLine(" Invalid Input");
                    Console.WriteLine(" More Details about Error: \n\n" + fex.ToString() + "\n\n");
                }

                //Parent Exception: Catch all type of exception

                catch (Exception ex)
                {
                    Console.WriteLine(" Other Exception raised" + ex.ToString() + "\n\n");
                }

                
                //Finally block: it always executes
                finally
                {
                    Console.WriteLine(" Finally Block: For Continue Press Enter and for Exit press Ctrl + c");
                    Console.ReadLine();
                }
                
            }
            while (bool25);

        }// private static void RunExercise25()---------------------------------------------------------------------------------



        private static void RunExercise26()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("GetFolderPath: My Documents:       {0}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine("GetFolderPath: My Pictures:        {0}", Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            Console.WriteLine("GetFolderPath: Program Files X86:  {0}", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            Console.WriteLine("GetFolderPath: Cookies:            {0}", Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            Console.WriteLine("GetFolderPath: Current Directory:  {0}", Environment.CurrentDirectory);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("GetFolderPath: Desktop:            {0}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            Console.WriteLine("-------------------------------End-------------------------------");


            string path26 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MyTest.txt";

            if (!File.Exists(path26))
            {
                // Create a file to write to.
                //using StreamWriter sw = File.CreateText(path);
                using StreamWriter writer26 = new StreamWriter(path26, true);
                {
                    writer26.WriteLine("Hello");
                    writer26.WriteLine("And");
                    writer26.WriteLine("Welcome");
                    writer26.Close();
                }                
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path26))
            {
                string str26 = "";
                while ((str26 = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str26);
                    Console.WriteLine("-----------------------------------------------------------------");
                }
            }       

        }//private static void RunExercise26()-----------------------------------------------------------------------


        private static void RunExercise27()
        {


            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr27 = new StreamReader("MyName.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr27.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e27)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e27.Message);
            }



        }// private static void RunExercise27()-----------------------------------------------------------------------------------------




        private static void RunExercise28()
        {


            try
            {
                string path26 = "C:\\Users\\Magi.MAGI-VAIO\\source\repos\\Exercise.0.Prerequisite\\Exercise.0.Prerequisite\\MyName.txt";

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw28 = new StreamWriter(path26, true);
                //Write a line of text
                sw28.WriteLine("Hello World!!");
                //Write a second line of text
                sw28.WriteLine("From the StreamWriter class");
                //Close the file
                sw28.Close();
            }
            catch (Exception e28)
            {
                Console.WriteLine("Exception: " + e28.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }            

        }// private static void RunExercise28()-----------------------------------------------------------------------------------------





    }// class Program

}// namespace Exercise._0.Prerequisite
