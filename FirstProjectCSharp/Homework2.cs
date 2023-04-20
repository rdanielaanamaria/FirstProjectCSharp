using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;


public class Exercises
{
    public static void Main(string[] args)
    {
        //Exercise1();
        //Exercise2();
        Exercise3();
        Exercise5();
    }
    //Write a program that reads a number from the keyboard. Check whether that number is divisible by 7 and 11 or not.

    //public static void Exercise1()
    //{
    //    int num;
    //    Console.WriteLine("Enter any number(to see if is divisble by 7 and 11): ");
    //    num = int.Parse(Console.ReadLine());
    //    if ((num % 7 == 0) && (num % 11 == 0))
    //    {
    //        Console.WriteLine("The number is divisible both by 7 and 11.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("This number is not divisible both by 7 and 11.");
    //    }
    //}
    ////Check whether a given year is leap year or not.
    //public static void Exercise2()
    //{
    //    int year;
    //    Console.WriteLine("Enter a number (to see if we are in a leap year):");
    //    year = int.Parse(Console.ReadLine());
    //    if ((year % 4 == 0) && ((year % 100 == 0) || (year % 400==0))){
    //        Console.WriteLine("This is a lep year");
    //    }
    //    else { Console.WriteLine("The year is not leap."); }
    //}


    //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime number is 13. What is the 47th prime number?
    public static void Exercise3()
    {
        //Console.Write("Enter The Start Number: ");
        //int startNumber = int.Parse(Console.ReadLine());
        //Console.Write("Enter the End Number : ");
        //int endNumber = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are : ");
        //for (int i = startNumber; i <= endNumber; i++)
        //{
        //    int counter = 0;
        //    for (int j = 2; j <= i / 2; j++)
        //    {
        //        if (i % j == 0)
        //        {
        //            counter++;
        //            break;
        //        }
        //    }

        //    if (counter == 0 && i != 1)
        //    {
        //        Console.Write("{0} ", i);
        //    }
            int ct = 0, n = 0, i = 1, j = 1;
            while (n < 47)
            {
            j = 1;
                ct = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                        ct++;
                    j++;
                }
            if (ct == 2)
                {
                Console.Write(i);
                Console.Write(" ");
                //Console.Write("The last prime number in this row is the 47th.");
                n++;
                }
                i++;
            }
    }

    //Find the sum of digits of a number read from the keyboard.

    public static void Exercise5()
    {
        int number, sum = 0, modulus;
        Console.WriteLine("Enter a number containing from multiple digits: ");
        number = int.Parse(Console.ReadLine());
        while(number>0)
        {
            modulus = number % 10;
            sum = sum + modulus;
            number = number / 10;
        }
        Console.Write("Sum of numbers introduced is: " + sum);
        
    }
}

