using System;
using System.Collections.Generic;
using System.Linq;

// 1
{
    int[] nums = { 1, 2, 3, 4, 5 };

    IEnumerable<int> result = nums.Where( n => n > 3);
    foreach (int i in result)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}

// 2
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

    IEnumerable<string> result = names.Where(n => n.Contains("a"));

    foreach(string s in result)
    {
        Console.WriteLine(s); 
    }
    Console.WriteLine();
}

// 3
{
    string[] names = { "Tom", "Dick", "Harry" };

    IEnumerable<string> result = names.Select(n => n.ToUpper());

    foreach (string s in result)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();
}

// 4
{
    string[] colors = { "Red", "Green", "Blue" };
    var sorted = colors.OrderBy(c => c);

    foreach (string s in sorted)
    {
        Console.WriteLine(s); 
    }
    Console.WriteLine();
}

// 5
{
    int[] nums = { 3, 1, 4, 1, 5, 9, 2, 6 };
    var sorted = nums.OrderByDescending(c => c);

    foreach (int i in sorted)
    {
        Console.Write($"{i} "); 
    }
    Console.WriteLine();   
}

// 6
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

    IEnumerable<string> sortedSelected = names
        .Where(n => n.Contains("a"))
        .OrderBy(n => n.Length)
        .Select(n => n.ToUpper());
    foreach (string s in sortedSelected)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();
}

// 7
{
    int[] nums = { 1, 2, 3, 4, 5 };

    var query = from n in nums
                where n % 2 == 0
                select n;
    foreach (int i in query)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}

// 8
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

    var query = from n in names
                where n.Contains("a")
                orderby n.Length
                select n.ToUpper();
    foreach (string s in query)
    {
        Console.WriteLine(s); 
    }
    Console.WriteLine();
}

// 9
{
    int[] nums = { 3, 2, 1, 4, 5 };

    var method = nums
        .Where(n => n % 2 != 0)
        .OrderBy(n => n);

    var query = from n in nums
                where n % 2 != 0
                orderby n
                select n;

    Console.WriteLine("메서드 구문: ");
    foreach (int i in method)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
    Console.WriteLine("쿼리 구문: ");
    foreach (int i in query)
    {
        Console.Write($"{i} ");
    }
}