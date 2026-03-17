using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

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
             orderby n.Price
             select n;
var query2 = from n in gameItems
             where n.Type == "무기"
             orderby n.Grade
             select n;
