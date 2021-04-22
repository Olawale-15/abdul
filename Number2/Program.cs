using System;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random random = new Random();

            int point;
        int firstDie = rollDie();
        int secondDie = rollDie();
        int sumOfTwoDice = firstDie + secondDie;

        if(sumOfTwoDice == 2 || sumOfTwoDice == 3 || sumOfTwoDice == 12)
        {
    
    
            Console.WriteLine("You rolled %d + %d = %d",firstDie,secondDie,sumOfTwoDice);
             Console.WriteLine("You lose");
        }
        else if(sumOfTwoDice == 7 || sumOfTwoDice == 11)
        {
    
    
            Console.WriteLine("You rolled %d + %d = %d",firstDie,secondDie,sumOfTwoDice);
             Console.WriteLine("You win");
        }
        else
        {
    
    
            point = sumOfTwoDice;
            Console.WriteLine("You rolled %d + %d = %d",firstDie,secondDie,sumOfTwoDice);
             Console.WriteLine("point is %d\n", point);
            do {
    
    
                firstDie = rollDie();
                secondDie = rollDie();
                sumOfTwoDice = firstDie + secondDie;
            }while(sumOfTwoDice !=7 && sumOfTwoDice != point);

             Console.WriteLine("You rolled %d + %d = %d",firstDie,secondDie,sumOfTwoDice);
            if(sumOfTwoDice == point)
                Console.WriteLine("You win");
            else if(sumOfTwoDice == 7)
                Console.WriteLine("You lose");
        }
    }
    public static int rollDie() {
    
    
        return (int)(Math.random() * 6 + 1);
        }
        
    }
}
