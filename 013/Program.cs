//13. 구구단 출력
//2x1=2
//2x2=4
//2x3=6
//2x4=8
//x : 2~9, y : 1~9

for (int x = 2; x <= 9; x++)
{
	for (int y = 1; y <= 9; y++)
        Console.WriteLine("{0}X{1}={2}\t", x, y, x*y);
    Console.WriteLine();
}
