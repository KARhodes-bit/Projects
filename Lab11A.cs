/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab:11
*/


class Lab11A
{
    static void Main(string[] args)
    {
        
        string ch = "YES";
        int num;
    
        while (ch.ToUpper().Equals("YES"))
        {
            
            Console.WriteLine("Menu");
            Console.WriteLine("0 - Hello World");
            Console.WriteLine("1 - Goodbye Moon");
            Console.WriteLine("2 - Walking on Sunshine");
            Console.WriteLine();
        
            Console.Write("\nWhat would you like to do: ");
       
            num = int.Parse(Console.ReadLine());
         
            
            if (num == 0)
            {
               
                Console.WriteLine("Hello!");
               
             
            }
            else if (num == 1)
            {
               
                Console.WriteLine("Ok,bye.");
                
           
            }
            else if (num == 2)
            {
              
                Console.WriteLine("WHOA!");
                
           
            }

            Console.Write("Type \"YES\" to rerun. ");
            
            ch = Console.ReadLine();
           
          
        }
        Console.WriteLine("Program Ends");
      
        
        Console.ReadKey();
    }

}


