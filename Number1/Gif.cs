using System;
namespace Number1
{
    public class Gif
    {
    //      static bool oneDigit(int num) 
    // { 
        
    //     return (num >= 0 && num < 10); 
    // } 
      
    
    // static bool isPalUtil(int num, int dupNum) 
    // { 
        
    //     if (oneDigit(num)) 
    //         return (num == (dupNum) % 10); 
      
        
    //     if (!isPalUtil(num/10, dupNum)) 
    //         return false; 
      
       
    //     dupNum /= 10; 
      
        
    //     return (num % 10 == (dupNum) % 10); 
    // } 
      
   
    // static bool isPal(int num) 
    // { 
       
    //     if (num < 0) 
    //     num = -num; 
      
       
    //     int dupNum = num; 
      
    //     return isPalUtil(num, dupNum); 
    // } 
      
    
    // static void printPalPrimesLessThanN(int n) 
    // { 
        
    //     bool []prime = new bool[n+1]; 
          
    // for (int i=0;i<n+1;i++) 
    // prime[i]=true; 
          
    //     for (int p = 2; p*p <= n; p++) 
    //     { 
            
    //         if (prime[p]) 
    //         { 
                
    //             for (int i = p*2; i <= n; i += p){ 
    //                 prime[i] = false;} 
    //         } 
    //     } 
      
        
    //     for (int p = 2; p <= n; p++){ 
      
       
    //     if (prime[p] && isPal(p)){ 
    //         Console.Write(p + " "); 
    //         } 
    //     } 
    // } 
      
     
    // public static void Main()  
    // { 
    //     int n = 100; 
    //     Console.Write("Palindromic primes smaller than or " +  
    //                   "equal to are :", n); 
    //     printPalPrimesLessThanN(n); 
        
    // } 
    }
}