using System;

namespace Number5
{
    public class Employee
    {
        public static void getInfo()
        {    
            
            Console.WriteLine("Enter Your Salary");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hours Work Per Day");
            int hoursWorkPerDay = int.Parse(Console.ReadLine());
           
             AddSalary(salary);
             AddHoursWorkPerDay(salary, hoursWorkPerDay);
        }
        public static void AddSalary( int salary)
        {  
             if(salary > 500)
            {
                Console.WriteLine($"10 Dollar Is Added To Your Money {salary + 10} ");
            }
            else{
                Console.WriteLine("You Have No Reward");
            }
            
        }
        public static void AddHoursWorkPerDay( int salary, int hoursWorkPerDay)
        {     
              if( hoursWorkPerDay > 6 && salary<500)
              {
                  Console.WriteLine($" Your new salary is {salary + 5 +10}");
              }
              else if(hoursWorkPerDay < 6 && salary < 500){
                  Console.WriteLine("");
              }
              else if(hoursWorkPerDay > 6 && salary > 500)
              {
                  Console.WriteLine($"Only $5 is Added To Your Salary {salary}");
              }
              else{
                  Console.WriteLine($"You Have No Salary Rewarded{salary}");
              }
        }

    }
}