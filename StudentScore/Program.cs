using System;
using System.Collections.Generic;
using System.Linq;

List<Student> students = new List<Student>
{
    new Student("김철수", "수학", 85),
    new Student("김철수", "영어", 78),
    new Student("이영희", "수학", 92),
    new Student("이영희", "영어", 88),
    new Student("박민수", "수학", 76),
    new Student("박민수", "영어", 82),
    new Student("정지은", "수학", 95),
    new Student("정지은", "영어", 91),
};

var query1 = students.Where(n => n.Score >= 85);
var query2 = students.Where(n => n.Subject == "수학");
var query3 = students.OrderByDescending(n => n.Score);
var query4 = students.Average(n => n.Score);
var query5_1 = students.Where(n => n.Subject == "수학").Min(n => n.Score);
var query5_2 = students.Where(n => n.Subject == "수학").Max(n => n.Score);
var query6 = students.Any(n => n.Score >= 90);
var query7 = students.All(n => n.Score >= 70);
var query8 = students.Select(n => n.Name).Distinct();
var query9 = students.OrderByDescending(n => n.Score).First();
var query10 = students.OrderBy(n => n.Subject).ThenByDescending(n => n.Score).ThenBy(n => n.Name);

Console.WriteLine("=== 문제 1: 85점 이상 ===");
foreach (var item in query1)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 문제 2: 수학 과목 ===");
foreach (var item in query2)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 문제 3: 점수 내림차순 ===");
foreach (var item in query3)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 문제 4: 전체 평균 ===");
Console.WriteLine($"{query4:F3}점");
Console.WriteLine();
Console.WriteLine("=== 문제 5: 수학 최고/최저 점수 ===");
Console.WriteLine($"최고: {query5_2}점\n최저: {query5_2}점");
Console.WriteLine();
Console.WriteLine("=== 문제 6: 영어 90점 이상 존재 여부 ===");
Console.WriteLine(query6);
Console.WriteLine();
Console.WriteLine("=== 문제 7: 모두 70점 이상 여부 ===");
Console.WriteLine(query7);
Console.WriteLine();
Console.WriteLine("=== 문제 8: 학생 이름 (중복 제거) ===");
foreach (var item in query8)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 문제 9: 수학 최고점 학생 ===");
Console.WriteLine(query9.Name);
Console.WriteLine();
Console.WriteLine("=== 문제 10: 과목별 정렬 ===");
foreach (var item in query10)
{
    Console.WriteLine(item);
}


