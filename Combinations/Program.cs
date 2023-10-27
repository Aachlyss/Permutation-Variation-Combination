using System;
using System.Collections.Generic;

class Combinations
{
    static void GenerateCombinations(List<int> elements, int k, List<int> combination, int index, int start)
    {
        if (index == k)
        {
            Console.WriteLine(string.Join(" ", combination));
            return;
        }

        for (int i = start; i < elements.Count; i++)
        {
            combination[index] = elements[i];
            GenerateCombinations(elements, k, combination, index + 1, i + 1);
        }
    }

    static void Main()
    {
        List<int> elements = new List<int> { 1, 2, 3 };
        int k = 2; // Combination length
        List<int> combination = new List<int>(new int[k]);
        GenerateCombinations(elements, k, combination, 0, 0);
    }
}
