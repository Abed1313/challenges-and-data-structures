 ﻿namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
  int[] arr = { 1, 2, 3, 1, 2, 3 };
  List<int> arr3 = new List<int>();

  for (int i = 0; i < arr.Length; i++)
  {
      for (int j = i + 1; j < arr.Length; j++)
      {
          if (arr[i] == arr[j] && !arr3.Contains(arr[i]))
          {
              arr3.Add(arr[i]);
          }
      }
  }
  Console.WriteLine("Duplicates: " + string.Join(", ", arr3));

  }
        }
    }