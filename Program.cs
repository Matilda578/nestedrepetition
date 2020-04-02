using System;

namespace Nested
{
    class Program
    {
        static void Main(string[] args)
        {
           int totalloops = 5;  
         int currentloop, nestedcurrentloop ;
         for (currentloop = 1; currentloop <= totalloops; currentloop++)  
         {  
           
            for (nestedcurrentloop = 5; nestedcurrentloop >= currentloop; nestedcurrentloop--)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
         
      }  
        }
    }
