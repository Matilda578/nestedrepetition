using System;

namespace Nested
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("How many xs do you want?!??!"); //asking for user input
           string usersad = Console.ReadLine(); //getting input as a string
          //create an integer variable
          int BLAH; 
          //make blah mean what the user input but as an integer
         BLAH = Int32.Parse(usersad);
                     
           int totalloops = 5;  
         int currentloop, nestedcurrentloop ;
         for (currentloop = 1; currentloop <= totalloops; currentloop++)  
         {  
           
            for (nestedcurrentloop = BLAH; nestedcurrentloop >= currentloop; nestedcurrentloop--)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
         
      }  
        }
    }
