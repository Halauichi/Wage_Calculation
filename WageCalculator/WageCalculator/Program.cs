using System;

namespace WageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables (input)
            
            int overTimeHours = 0;
            double overtTimePay = 0;
            double grossPay = 0;
            
            //add logic to calculate gross pay (business logic/algorithm)
             for (int i = 0; i < 2; i++)
            {
                
                if (hoursWorked > 40)
                {
                    takeinput();
                    //Calculates overtime pay
                    overTimeHours = hoursWorked - 40;
                    overtTimePay = overTimeHours * (payrate * 1.5);
                    grossPay = (hoursWorked - overTimeHours) * payrate;
                    //Add OvertimePay to grossPay using the += syntax
                    //You could have typed grossPay = grossPay + overTimePay syntax.
                    //Both syntax gives the same results
                    grossPay += overtTimePay;
                }
                else
                {
                    //reset overTimePay variable so it won't display the previous value
                    overtTimePay = 0;
                    grossPay = hoursWorked * payrate;
                }
                //display the output to the system console window
                Console.WriteLine("Employee name {0}", name);
                Console.WriteLine("Overtime pay {0:C}", overtTimePay);
                Console.WriteLine("Gross pay {0:C}", grossPay);
                Console.WriteLine(String.Empty);
            }
        
            }
        public void takeinput()
        {
            string name = String.Empty;
            int hoursWorked = 0;
            double payrate = 0;
                System.Console.WriteLine("Enter Employee Name:");
                name = Console.ReadLine();
                System.Console.WriteLine("Enter Hours worked:");
                //Converting input stream string value to an int data type using the Parse method
                hoursWorked = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter Pay rate:");
                //Converting input stream string value to a double data type using the Parse method
                payrate = double.Parse(Console.ReadLine());
    }
    }
}
