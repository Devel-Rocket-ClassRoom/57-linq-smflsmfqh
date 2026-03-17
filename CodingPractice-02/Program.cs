using System;
using System.Collections.Generic;
using System.Linq;

// 1
{
    int[] nums = { 1, 2, 3, 4, 5 };
    Console.WriteLine($"합계: {nums.Sum()}");
    Console.WriteLine($"개수: {nums.Count()}");
    Console.WriteLine($"평균: {nums.Average()}");
    Console.WriteLine();
}

// 2
{
    int[] nums = { 3, 1, 4, 1, 5, 9, 2, 6 };
    Console.WriteLine($"최솟값: {nums.Min()}");
    Console.WriteLine($"최댓값: {nums.Max()}");
    Console.WriteLine();
}

// 3
{
    int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Console.WriteLine($"짝수 합계: {nums.Where(x => x % 2 == 0).Sum()}");
    Console.WriteLine($"5보다 큰 숫자 개수: {nums.Where(x => x > 5).Count()}");
    Console.WriteLine();
}

// 4
{
    int[] nums = { 10, 20, 30, 40, 50 };
    Console.WriteLine($"첫 번째: {nums.First()}");
    Console.WriteLine($"마지막: {nums.Last()}");
    Console.WriteLine();
}

// 5
{
    int[] nums = { 1, 2, 3, 4, 5 };
    Console.WriteLine($"3보다 큰 첫 번째: {nums.Where(n => n > 3).First()}");
    Console.WriteLine();
}

// 6
{
    int[] nums = { 10, 20, 30, 40, 50 };

    var takeThree = nums.Take(3);
    var skipTwo = nums.Skip(2);
    Console.WriteLine("처음 3개: ");
    Console.WriteLine(string.Join(" ", takeThree));
    Console.WriteLine("2개 건너뛴 후:");
    Console.WriteLine(string.Join(" ", skipTwo));
    Console.WriteLine();
}

// 7
{
    int[] nums = { 1, 2, 3, 4, 5 };
    Console.WriteLine($"요소 존재: {nums.Any()}");
    Console.WriteLine($"짝수 존재: {nums.Any(n => n % 2 == 0)}");
    Console.WriteLine($"모두 양수: {nums.All(n => n > 0)}");
    Console.WriteLine();
}

// 8
{
    int[] nums = { 1, 2, 3, 4, 5 };
    Console.WriteLine($"3 포함: {nums.Contains(3)}");
    Console.WriteLine($"10 포함: {nums.Contains(10)}");
    Console.WriteLine();
}

// 9
{
    int[] nums = { 1, 2, 2, 3, 3, 3, 4, 5 };
    var newNums = nums.Distinct();
    foreach ( int i in newNums )
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

// 10
{
    int[] first = { 1, 2, 3 };
    int[] second = { 3, 4, 5 };

    Console.WriteLine("Concat: ");
    Console.WriteLine($"{string.Join(" ", first.Concat(second))}");
    Console.WriteLine("Union: ");
    Console.WriteLine($"{string.Join(" ", first.Union(second))}");
    Console.WriteLine();
}

// 11
{
    List<int> nums = new List<int>{ 1, 2, 3 };

    var query = from n in nums
                where n > 1
                select n;
    nums.Add(4);

    Console.WriteLine("결과:");
    foreach (int i in query)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}

// 12
{
    List<int> nums = new List<int> { 1, 2, 3 };
    int count = nums.Count();

    nums.Add(4);
    Console.WriteLine($"개수: {count}");
    Console.WriteLine();
}

// 13
{
    List<int> nums = new List<int> { 1, 2, 3 };

    var filtered = nums.Where(n => n > 1).ToList();
    nums.Add(4);

    Console.WriteLine("결과: ");
    foreach(int i in filtered)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}

// 14
{
    string[] names = { "홍길동", "김철수", "이영희" };

    var selected = names.Select(n => new { Name = n, Length = n.Length });

    foreach (var item in selected)
    {
        Console.WriteLine($"이름: {item.Name}, 길이: {item.Length}");
    }
    Console.WriteLine();
}

// 15
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

    var Aquery = from n in names
                where n.Contains("a")
                select n;

    var orderQuery = from n in names
                     orderby n
                     select n;
    Console.WriteLine($"'a' 포함 이름 개수: {Aquery.Count()}");
    Console.WriteLine($"알파벳 순 첫 번째: {orderQuery.First()}");
}
