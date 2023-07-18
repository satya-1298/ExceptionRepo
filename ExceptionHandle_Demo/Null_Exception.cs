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
            try
            {
                string str = null;
                //string hr = str.Substring(2);
                //Console.WriteLine(hr);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
