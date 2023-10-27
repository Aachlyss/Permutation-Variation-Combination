using System;
using System.Collections.Generic;

class Variations
{
    static void GenerateVariations(List<int> elements, int k, List<int> variation, int index)
    {
        if (index == k)
        {
            Console.WriteLine(string.Join(" ", variation));
            return;
        }

        for (int i = 0; i < elements.Count; i++)
        {
            variation[index] = elements[i];
            GenerateVariations(elements, k, variation, index + 1);
        }
    }

    static void Main()
    {
        List<int> elements = new List<int> { 1, 2, 3 };
        int k = 2; // Variation length
        List<int> variation = new List<int>(new int[k]);
        GenerateVariations(elements, k, variation, 0);
    }
}
