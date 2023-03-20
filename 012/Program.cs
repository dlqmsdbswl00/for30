//12. n줄의 피라미드 (4)
//    *
//   ***
//  *****
// *******
//*********

//1번째 줄 : 공백 4개,     별 1개
//2번째 줄 : 공백 3개,     별 3개
//3번째 줄 : 공백 2개,     별 5개
//n번째 줄 : 공백 (n-i)개, 별 (2i-1)개

Console.Write("출력할 피라미드의 줄 : ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= (n-i); j++)
        Console.Write(" ");
    for (int j = 1; j <= (2*i-1); j++)
        Console.Write("*");
    Console.WriteLine();
}