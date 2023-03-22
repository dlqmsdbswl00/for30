//20. 랜덤으로 10칸의 배열에 숫자 넣기

Random r = new Random();

for (int i = 0; i < 10; i++)
    Console.WriteLine(r.Next(10));
Console.WriteLine(); 