using System;
using System.ComponentModel;


class Person
{
    public string Name;
}


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program that allows the user to enter a number then print it.

             Console.Write("Enter a Number: ");

             String input = Console.ReadLine();
             Console.WriteLine(input);
            

            /*
                2.Write C# program that converts a string to an integer,
                but the string contains non-numeric characters.
                And mention what will happen
             
             */
              string inputString = "123abc";
             try
              {
                  int result = int.Parse(inputString);
                  Console.WriteLine( result);
              }
              catch (FormatException)
              {
                  Console.WriteLine("Input string was not in a correct format contain non numeric characters.");
              }
            


            // 3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            double num1 = 10.5;
             double num2 = 4.2;

             double sum = num1 + num2;
             double difference = num1 - num2;
             double product = num1 * num2;
             double quotient = num1 / num2;

             Console.WriteLine("Number 1: " + num1);
             Console.WriteLine("Number 2: " + num2);
             Console.WriteLine("Sum: " + sum);
             Console.WriteLine("Difference: " + difference);
             Console.WriteLine("Product: " + product);
             Console.WriteLine("Quotient: " + quotient);

            //4.Write C# program that Extract a substring from a given string.
            
            string original = "Hello, World!";

            string substring = original.Substring(7, 5);

            Console.WriteLine("Original String: " + original);
            Console.WriteLine("Extracted Substring: " + substring);
            

            //5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


            
            int a = 10;
            int b = a;  

            b = 20;     

            Console.WriteLine("Value of a: " + a);
            Console.WriteLine("Value of b: " + b);
            

            //6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            
            Person person1 = new Person();
            person1.Name = "Alice";

            Person person2 = person1;  

            person2.Name = "Bob";  

            Console.WriteLine("person1.Name: " + person1.Name);
            Console.WriteLine("person2.Name: " + person2.Name);

            


            //7.Write C# program that take two string variables and print them as one variable

             Console.Write("Enter your first name: ");
             String firstName = Console.ReadLine();

             Console.Write("Enter your last name: ");
             String lastName = Console.ReadLine();

             Console.WriteLine(firstName +" "+lastName);
            
            //8.Which of the following statements is correct about the C#.NET code snippet given below?
            //answer: b)A value 1 will be assigned to d.



            //9.  Which of the following is the correct output for the C# code given below?
            //answer: d) 6 1


            //10.What will be the output of the C# code given below?
            //answer :d)7 7
        }
    }
}
