using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s=Console.ReadLine().Split(" ");
            for (int i = 0; i < s.Count(); i+=2)
            {
                if (s[i]!=s[i+1])
                {                    
                    Console.Write((int.Parse(s[i])+int.Parse(s[i+1]))+ " ");
                }
                else
                {
                    Console.Write((Math.Pow(2*Double.Parse(s[i]),2))+" ");                                    
                }
                
            }
        }
    }
}