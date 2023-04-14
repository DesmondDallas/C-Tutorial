using System.Collections;
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] array2 = new string[] { "one", "two", "three", "four", "five", "six", "seven" };

	  string[] names = new string[] { "Des", "Simon", "Claire", "Sally", "Hannah", "Karen", "Simone" };
      
      
      
        for (int i = 0; i < array2.Length; i++) {
        	for (int j = 0; j < names.Length; j++) {
                Console.WriteLine(array2[i]  + " " + "friends name is: " + names[j] + "\n");  
        	}
        }
    }
  }

}