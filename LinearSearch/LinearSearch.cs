using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace LinearSearch
{
	class LinearSearch
	{
		string[] arr = File.ReadAllLines("scores.txt");

		public void Start()
		{
			Output(CheckArray(GetSearchItem()));
		}

		public int GetSearchItem()
		{
			WriteLine("Enter your search term.");
			return Convert.ToInt32(ReadLine());
		}

		public int CheckArray(int search_term)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (search_term == Convert.ToInt32(arr[i]))
				{
					return i;
				}
			}

			return -1;
		}

		public void Output(int index)
		{
			if (index == -1)
			{
				WriteLine("Your search term could not be found");
			}
			else
			{
				WriteLine($"Your search can be found at index {index}.");
			}
		}
	}
}
