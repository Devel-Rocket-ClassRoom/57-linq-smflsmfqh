using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

List<Product> products = new List<Product>
{
    new Product("Laptop", "Electronics", 1200),
    new Product("Mouse", "Electronics", 25),
    new Product("Keyboard", "Electronics", 75),
    new Product("Shirt", "Clothing", 50),
    new Product("Pants", "Clothing", 100),
    new Product("Desk", "Furniture", 250),
    new Product("Chair", "Furniture", 150),
    new Product("Monitor", "Electronics", 300)
};

var query1 = from n in products
             where n.Price >= 100
             select n;
var query2 = from n in products
             where n.Category == "Electronics"
             select n;
var query3 = from n in products
             orderby n.Name
             select n;
var query4 = products.Average(n => n.Price);
var query5 = products.Min(n => n.Price);
var query6 = products.Max(n => n.Price);
var query7 = products.Where(n => n.Category == "Electronics").Average(n => n.Price);
var query8 = products.Where(n => n.Name.Contains("o")).Select(n => n.Name.ToUpper());
var query9 = products.Where(n => n.Category == "Clothing").OrderByDescending(n => n.Name);
var query10 = products
            .Where(n => n.Price > 50 && n.Price < 300)
            .OrderBy(n => n.Price)
            .ThenBy(n => n.Name);

Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
foreach (var item in query1)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();
Console.WriteLine("=== 문제 2: Electronics 카테고리 ===");
foreach (var item in query2)
{
    Console.WriteLine($"{item.Name} - {item.Category} - {item.Price}원");
}
Console.WriteLine();
Console.WriteLine("=== 문제 3: 이름순 정렬 ===");
foreach (var item in query3)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();     
Console.WriteLine("=== 문제 4: 평균가격 ===");
Console.WriteLine($"{query4:F2}원");
Console.WriteLine();   
Console.WriteLine("=== 문제 5: 가장 저렴한 상품 ===");
Console.WriteLine($"{products.OrderBy(n => n.Price).First()} - {query5}원");
Console.WriteLine();   
Console.WriteLine("=== 문제 6: 가장 비싼 상품 ===");
Console.WriteLine($"{products.OrderBy(n => n.Price).Last()} - {query6}원");
Console.WriteLine();     
Console.WriteLine("=== 문제 7: Electronics 평균가격 ===");
Console.WriteLine($"{query7}원");
Console.WriteLine();
Console.WriteLine("=== 문제 8: 'o' 포함 상품 (대문자) ===");
foreach (var item in query8)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 문제 9: Clothing 역순 ===");
foreach (var item in query9)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();
Console.WriteLine("=== 문제 10: 가격 50~300, 복합 정렬 ===");
foreach (var item in query10)
{
    Console.WriteLine($"{item.Name} - {item.Price}");
}
       

