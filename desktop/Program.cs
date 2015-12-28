using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Budsoft();
            Console.ReadKey();

           
        }



       static void Budsoft()
        {

            for (int i = 1; i <= 100; i++)
            {


                if (i % 15 == 0)
                { 
                
                   Console.WriteLine("BudSoft");
                
                
                
                }
                else if (i % 5 == 0)

                {

                    Console.WriteLine("Soft");
                
                }
                else if (i % 3 == 0)
                {


                    Console.WriteLine("Bud");


                }

                else
                {

                    Console.WriteLine(i.ToString());



                
                
                
                
                }
            
            
            
            
            
            }
         
        

        
        
        
        }




    }
}
