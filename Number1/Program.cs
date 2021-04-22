using System;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
 
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
 
                }
                if (isPrime)
                {
                    Console.Write("\t" +i);
                }
                isPrime = true;
            }
            Console.ReadKey();
    //         Console.WriteLine("Hello World!");

    //          int counter = 1;
    //     int start = 2;      

    //     isPalindrome(start);
    //     isPrime(start);

    //     while (counter <= 50) {
    //         if (isPrime(start) && isPalindrome(start)) {
    //            Console.WriteLine(start + " ");
    //             if (counter % 10 == 0) {
    //                 Console.WriteLine();
    //                 counter++;
    //             }
    //             start++;
    //         }
    //     }
    // }
    // public static bool isPalindrome(int x) {
    //     int reverse = 0;
    //     while(x > 0) {
    //     reverse = reverse * 10 + x % 10;
    //     x = x / 10;
    //     }
    //     if (reverse == x) {
    //         return true;
    //     }
    //     else {
    //         return false;
    //     }       
    // }
    // public static bool isPrime(int x) {
    //     if (x % 2 == 0 && x != 2) {
    //         return false;
    //     }
    }
}}
