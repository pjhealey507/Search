# Search
Linear, Binary, and Interpolation search algorithms

Linear Search

The linear search algorithm iterates through each element in the data set until it finds a match. For this reason it is best for small unsorted data sets 
but is usually less efficient than other algorithms. Linear search's worst case efficiency is O(n) and the best case is O(1) for an average of O(n/2). 

for each item in array
  if item is equal to search
    return search
  end if
end for


Binary Search

The binary search algorithm searches through sorted data sets by dividing the set in half, determining which half the searched term is in, discarding the 
other half, then repeating until the searched term is found. Binary search's best case efficiency is O(1) in the event that the middle term is the searched
term. In other cases, the efficiency is O(log n). 

   sorted_array
   array_size
   search_term

   min = 0
   max = n - 1

   while search_term not found
      if max < min
         return does not exist
   
      mid = min + ( max - min ) / 2
      
      if sorted_array[mid] < search_term
         min = mid + 1
         
      if sorted_array[mid] > search_term
         max = mid - 1 

      if sorted_array[mid] = search_term
         return mid
   end while
  

Interpolation Search

Interpolation search uses keys to divide the data set rather than halving it. Based on how close the searched term is to the keys, the algorithm can start 
narrowing down the data set. Interpolation search's worst case efficiency is O(n) while its best case is O(log(log(n))). 

   min = 0
   mid = -1
   max = n-1

   While search_term not found
   
      if min is equal to max OR arr[min] is equal to arr[max]
         return not found
      end if
      
      mid = min + ((max - min) / (arr[max] - arr[min])) * (search_term - arr[min]) 

      if arr[mid] = search_term
         return mid
      else 
         if arr[mid] < search_term
            min = mid + 1
         else if arr[mid] > search_term
            max = mid - 1
         end if
      end if
   End While
