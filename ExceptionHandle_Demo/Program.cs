using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1-TryCatch");
                Console.WriteLine("2-Custom Exception");
                Console.WriteLine("3-Null Exception");
                Console.WriteLine("4-Index out of range");
                Console.WriteLine("-------------------------------");
                int option =Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        HandleException handleException = new HandleException();
                        handleException.Display();
                        Console.WriteLine("-------------------------------");
                        break;
                   case 2:
                        DivideByZero_Exception divideByZero_Exception = new DivideByZero_Exception();
                        divideByZero_Exception.Custom();
                        Console.WriteLine("-------------------------------");
                        break;
                    case 3:
                        Null_Exception null_Exception = new Null_Exception();   
                        null_Exception.Display();
                        break;
                    case 4:
                        IndexOut_Of_Range_Exception indexOut_Of_Range= new IndexOut_Of_Range_Exception();
                        indexOut_Of_Range.Range();
                        break;


                }
            }
           
        }
    }
}
