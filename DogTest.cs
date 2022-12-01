* DogTest.cs */ 
/* 
	File name: 	DogTest.cs
	Purpose:	Test harness for Dog class
	Author:		Shatha Almaktoum
	Date:		30-Nov-2022
	Version:	1.0
	Notes:
	
*/
using System.Collections.Generic

namespace VetPractice
{
	public class DogTest
	{
		
		public static Main (string [] args)
		{
			Dog Sparky = new Dog ("Sparky", "Collie", "Male", true);
			Dog Bruce  = new Dog ("Bruce", "Fox Terrier", "Male", false);
			Dog Lucy   = new Dog ("Lucy", "Dachshound", "Female", true);
			
			List<Dog> dogList = new List<Dog>();
			dogList.Add(Sparky);
			dogList.Add(Bruce);
			dogList.Add(Lucy);
			dogList.Sort();
			
			foreach (Dog dog in dogList)
			{
				Console.WriteLine(dog.Name);
			}
		}
	}
}