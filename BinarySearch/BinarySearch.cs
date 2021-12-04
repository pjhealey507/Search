using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace BinarySearch
{
	class BinarySearch
	{
		string[] arr = File.ReadAllLines("scores.txt");

		public void Start()
		{
			int search_term = GetSearchItem();
			SortArray();

			Output(CheckArray(0, arr.Length - 1, search_term));
		}

		public int GetSearchItem()
		{
			WriteLine("Enter your search term.");
			return Convert.ToInt32(ReadLine());
		}

		public void SortArray()
		{
			int n = arr.Length;
			for (int i = 1; i < n; ++i)
			{
				int key = Convert.ToInt32(arr[i]);
				int j = i - 1;

				while (j >= 0 && Convert.ToInt32(arr[j]) > key)
				{
					arr[j + 1] = arr[j];
					j = j - 1;
				}
				arr[j + 1] = key.ToString();
			}
		}

		public int CheckArray(int min, int max, int search_term)
		{	
			if (max >= min)
			{
				int mid = min + (max - min) / 2;

				if (Convert.ToInt32(arr[mid]) == search_term)
					return mid;

				if (Convert.ToInt32(arr[mid]) > search_term)
					return CheckArray(min, mid - 1, search_term);

				return CheckArray(mid + 1, max, search_term);
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
				WriteLine($"Your search can be found at index {index} in the sorted array.");
			}
		}
	}
}
