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
                var key = Console.ReadKey();
                char value = key.KeyChar;


                if (key.Key == ConsoleKey.Escape)
                {


                    Environment.Exit(0);

                    //if(key.Key > 0)
                    //{
                    //    Environment.Exit(0);
                    //}
                    //else
                    //{
                    //    return -1 ;
                    //}
                }
                //value = /*int.Parse(key.KeyChar.ToString());*/
                value = int.Parse(key.KeyChar.ToString());

                return value;
                    
            }            
        }
    }
}
