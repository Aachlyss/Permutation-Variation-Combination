using System;
using System.Collections.Generic;

class Permutations
{
    static void GeneratePermutations(List<int> elements, List<int> permutation, bool[] used)
    {
        if (permutation.Count == elements.Count)
        {
            Console.WriteLine(string.Join(" ", permutation));
            return;
        }

        for (int i = 0; i < elements.Count; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                permutation.Add(elements[i]);
                GeneratePermutations(elements, permutation, used);
                used[i] = false;
                permutation.RemoveAt(permutation.Count - 1);
            }
        }
    }

    static void Main()
    {
        List<int> elements = new List<int> { 1, 2, 3 };
        List<int> permutation = new List<int>();
        bool[] used = new bool[elements.Count];
        GeneratePermutations(elements, permutation, used);
    }
}
