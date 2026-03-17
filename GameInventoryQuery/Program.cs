using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;


List<GameItem> gameItems = new List<GameItem>
{
    new GameItem("나무 검", "무기", "일반", 100, 3),
    new GameItem("강철 대검", "무기", "희귀", 800, 1),
    new GameItem("용의 검", "무기", "전설", 5000, 1),
    new GameItem("가죽 갑옷", "방어구", "일반", 200, 2),
    new GameItem("미스릴 갑옷", "방어구", "희귀", 1200, 1),
    new GameItem("드래곤 갑옷", "방어구", "전설", 8000, 0),
    new GameItem("체력 물약", "소비", "일반", 50, 10),
    new GameItem("마나 물약", "소비", "일반", 80, 5),
    new GameItem("고급 물약", "소비", "희귀", 500, 0),
    new GameItem("엘릭서", "소비", "전설", 3000, 2),
};

var query1 = from n in gameItems
             where n.Price >= 500
             orderby n.Price descending
             select n;
var query2 = from n in gameItems
             where n.Type == "무기"
             orderby GradetoInt(n.Grade)
             select n;
var query3 = from n in gameItems
             let tn = n.Price * n.Quantity
             where tn >= 1000
             select n;
var query4 = from n in gameItems
             where n.Quantity == 0
             orderby n.Name
             select n;
var query5 = from n in gameItems
             where n.Grade == "전설"
             select new { Name = n.Name, Price = n.Price };

Console.WriteLine("=== 쿼리 1: 가격 500 이상 (가격 내림차순) ===");
foreach (var item in query1)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 2: 무기 타입 (등급순) ===");
foreach (var item in query2)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 3: 총 가치 1000 이상 ===");
foreach (var item in query3)
{
    Console.WriteLine($"{item.Name} - 총 가치: {item.Price * item.Quantity}");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 4: 품절 아이템 (이름순) ===");
foreach (var item in query4)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 5: 전설 등급 (이름과 가격) ===");
foreach (var item in query5)
{
    Console.WriteLine($"{item.Name} - {item.Price}원");
}

static int GradetoInt(string grade) => (grade) switch
{
    "일반" => 0,
    "희귀" => 1,
    "전설" => 2
};