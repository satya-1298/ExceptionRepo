using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle_Demo
{
    public class Null_Exception
    {
        public void Display()
        {
            //List<Exception> exceptions = new List<Exception>();
            //foreach (var item in exceptions)
            //{
            //    Console.WriteLine(item);
                
            //}
            //try
            //{
            //    string str = null;
            //   Console.WriteLine( str.Substring(2));

            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            string str = null;
            if(str != null) 
            {
                Console.WriteLine(str.Substring(5));
            }
            else
            {
                Console.WriteLine("string is null");
            }

        }
    }
}
