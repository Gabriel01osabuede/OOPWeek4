using System;

namespace week4class
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newInteger = {12,45,67,84,23};
            foreach(var item in newInteger)
            {
               Console.WriteLine(item);   
            }
            paraMethod(12);
            paraMethod(10,newInteger);
            
            //paraMethod();
            
            // int sum = 0;
            // int product = 0;
            // string fullname = null;
            // AddAndMultiplyAndName(50,40,out sum,out product,out fullname);
            // Console.WriteLine(sum + "----" + product +"-----" + fullname);

            // customer Amount = new customer(3000);
            // Console.WriteLine(Amount.credit());
            // Console.WriteLine(Amount.debit());
            // Console.WriteLine(Amount.balance());

            // double num = usingTypes();


            // int nulocalVar = 10;
            // Console.WriteLine();
            // MethodUsingByVal(nulocalVar);
            // Console.WriteLine(nulocalVar);

            // Console.WriteLine();
            // MethodUsingByRef(ref nulocalVar);
            // Console.WriteLine(nulocalVar);

           
           
        }
         //return types
         //so we can use any type in the method
         // definition and use the type to display records.
        public static double usingTypes()
        {
            return 90.0;
        }

        //refrence method
        public static void MethodUsingByRef(ref int IntPara)
        {
              IntPara = 20;
              Console.WriteLine(IntPara);
        }
        //value methods.
        public static void MethodUsingByVal(int IntPara)
        {
              IntPara = 20;
              Console.WriteLine(IntPara);
        }
        public static void AddAndMultiplyAndName(int firstnum,int secondnum,out int sumResult,out int ProductResult,out string MyName)
        {
              sumResult = firstnum + secondnum;
              ProductResult = firstnum * secondnum;
              MyName = "Andrerw Gabriel";
        }

        public static void paraMethod(int firstnumber, params int[] newIntergers)
        {
              Console.WriteLine(firstnumber);
              Console.WriteLine(newIntergers);
        }
    }
}
