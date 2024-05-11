// C# Program to illustrate how
// a destructor works
using System;

namespace Problem_Solving_Practices.Topics
{
    /*
     A Destructor is unique to its class i.e. there cannot be more 
     than one destructor in a class.
A Destructor has no return type and has exactly the same name 
as the class name (Including the same case).
It is distinguished apart from a constructor because of 
the Tilde symbol (~) prefixed to its name.
A Destructor does not accept any parameters and modifiers.
It cannot be defined in Structures. It is only used with classes.
It cannot be overloaded or inherited.
It is called when the program exits.
Internally, Destructor called the Finalize method on the base class of object.
         */
    public class Complex
    {
        double real, img;
        // Defining the constructor
        public Complex()
        {
            real = img = 0;
        }
        public void SetValue(double r, double i)
        {
            real = r;
            img = i;
        }

        // DisplayValue displays
        // values of real and img
        public void DisplayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
        }

        // Defining the destructor
        // for class Complex
        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }

    }  
    public class Vect:Complex
    {

        // Class members, private
        // by default
        double i, j, k;

        // Defining the constructor
        public Vect()
        {
            i = 0.0;
            j = 0.0;
            k = 0.0;
            Console.WriteLine("An instance of " +
                          "Vect class created");
        }

        // SetVector method sets 
        // the value of i, j, k
        public void SetVector(double iComponent,
                              double jComponent,
                              double kComponent)
        {
            i = iComponent;
            j = jComponent;
            k = kComponent;
        }

        // FindMagnitude calculates the 
        // value of the vector's magnitude
        public double FindMagnitude()
        {
            double m = 0.0;
            m = Math.Sqrt(i * i + j * j + k * k);
            return m;
        }
         
        ~Vect()
        {
            Console.WriteLine("The instance of" +
                       " Vect class Destroyed");
                }

    }
}


