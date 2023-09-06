using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace ARM_Engineer
{
    class Class1
    {
        public static int A()
        {
            

            while (true)
            {
              
                var n = Convert.ToInt32(Console.ReadLine());
                //var key = Console.ReadKey();
                foreach (var i in Enum.GetValues(typeof(States)))
                {
                    if( ((int)i == n))
                    {
                        return n;
                    }
                }

                //if(key.Key == ConsoleKey.Escape)
                //{
                    


                //    if (n > 0)
                //    {
                //        return n--;
                //    }
                    

                    

                    
                        


                //}

               


               







            }

            
        }
    }
}
