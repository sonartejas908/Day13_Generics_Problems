using System;
using System.Collections.Generic;
using System.Text;

namespace Day13Assigment
{
    public class MaximumNumberCheck

    {
        public static void MaximumIntegerNumber()
        {
        int firstvalue = 11;
        int secondvalue = 22;
        int thirdvalue = 33;
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                Console.WriteLine("Biggest number is :"+firstvalue);
            }    
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                Console.WriteLine("Biggest number is :"+secondvalue);
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                Console.WriteLine("Biggest number is :"+thirdvalue);
            }
        }
         
        
            public static void MaxFloat()
            {
                float firstvalue = 1.2F;
                float secondvalue = 11.3F;
                float thirdvalue = 5.26F;

                if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
                {
                    Console.WriteLine("Biggest number is" + firstvalue);
                }
                if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
                {
                    Console.WriteLine("Biggest number is " + secondvalue);
                }
                if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
                {
                    Console.WriteLine("Biggest number is " + thirdvalue);
                }
                throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }
        }
    }

