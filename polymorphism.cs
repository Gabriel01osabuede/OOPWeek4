using System;

namespace week4class
{
    class polymorphism
    {
        // Polymorphism(many forms)in c# is a concept by which we can perform a single action in different ways.
     //We can perform polymorphism in c# by method overloading and method overriding. 
     //If you overload a method in c#, it is the example of compile time(static) polymorphism
     //If you override a method in c#, it is the example of run time(dynamic) polymorphism

    public virtual void parentMethod()
    {
        Console.WriteLine("This is parent Class");
    } 

    public class childClass : polymorphism
    {
        public void childClassMethod()
        {
            Console.WriteLine("This Is Child Class");
        }
    }

    }
}