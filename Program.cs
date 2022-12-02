using System;//S0287, Lab 5, 3/7/2021, CIS 199-02, Purpose of Lab is to calculate average temperatures of given temps and display error message when incorrect temp range is entered
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;//Establishes count interger for temps put in
            double sum = 0;//Establishes sum variable
            double temp =0;//Establishes temp variable
            Console.WriteLine("Enter Temperatures from -20 to 130 (999 to stop)");//Writes line that displays values that can be put in and the SENTINEL that stops the calculation
            while (temp != 999)//While statement that sets rules while value is equal to 999 which is the number to stop
            {
                Console.WriteLine("Enter Temperature");//Writes the line for entering a temp
                temp = Convert.ToDouble(Console.ReadLine());//Line that convers temp to double in while statement for loop
                if (temp == 999)//If statement when temp equaling 999 is true
                {
                    break;//Creates a break in the code
                }
                if (temp >= -20 && temp <= 130)//Creates if statement for if temp is greater than or equal to 20 and less than or equal to 130 as valid ranges
                {
                    ++count;//Creates increment system for count of inputs
                    sum += temp;//Creates additions event 
                }
                else if(temp!=999)//Statement that creates alternative to previos statment, this creates an invalidation of the input number
                {
                    Console.WriteLine("Enter valid temperature between -20 and 130");//Writes to enter a valid temp if invalid one is put in
                }
                
            }
            Console.WriteLine("Temperature's Entered: " + count);//Displays final amount of temp counts put in
            Console.WriteLine("Average Temperature: " + (sum / count));//Displays final average temperature based on the division of sum and count
        }
    }
}
