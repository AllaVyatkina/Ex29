using System;

class Program {
  public static void Main (string[] args) {
    int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }

    return result;
} 
    int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");
  }
}