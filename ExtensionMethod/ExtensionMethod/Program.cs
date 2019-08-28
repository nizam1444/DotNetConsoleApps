using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "dotnet";
            Console.WriteLine("N is being added at the end of string "+s);
            s.addNatend();
          
        }

       
    }
    public static class extenmeth
    {
        public static void addNatend(this string s)
        {
            Console.WriteLine("modified string is " + s + "N");
            Console.ReadLine();
            //return s + "N";
        }
    }
}
