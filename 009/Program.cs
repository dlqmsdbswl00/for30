//9. 피라미드 (3)
//    *
//   **
//  ***
// ****
//*****

//1번째 줄 : 공백 4개,     별 1개
//2번째 줄 : 공백 3개,     별 2개
//3번째 줄 : 공백 2개,     별 3개
//n번째 줄 : 공백 (5-i)개, 별 i개

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <=(5-i); j++)
        Console.Write(" ");
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}