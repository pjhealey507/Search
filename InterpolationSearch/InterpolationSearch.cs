using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace InterpolationSearch
{
	class InterpolationSearch
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
            int pos;

            if (min <= max && search_term >= Convert.ToInt32(arr[min]) && search_term <= Convert.ToInt32(arr[max]))
            {
                pos = min + (((max - min) / (Convert.ToInt32(arr[max]) - Convert.ToInt32(arr[min]))) * (search_term - Convert.ToInt32(arr[min])));

                if (Convert.ToInt32(arr[pos]) == search_term)
                    return pos;

                if (Convert.ToInt32(arr[pos]) < search_term)
                    return CheckArray(pos + 1, max, search_term);

                if (Convert.ToInt32(arr[pos]) > search_term)
                    return CheckArray(min, pos - 1, search_term);
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
				WriteLine($"Your search can be found at index {index} of the sorted array.");
			}
		}
	}
}
