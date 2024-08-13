using System;

namespace StaticClass
{
    //contains only static
                    //data members
                    //methods
                    //constructors


    //creating static class
    static class Boruto{
        //creating static members for the static class 
        public static string A_name = "Boruto Izumaki";
        public static string L_name = "Csharp";
        public static int Age = 18;
        
        // creating a static method for the class 

        public static void details(){
            Console.WriteLine("The details of my Character is :");
        }
    }
}