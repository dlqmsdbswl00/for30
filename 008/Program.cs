//8. n줄의 피라미드 (2)
//...n
//*****
//****
//***
//**
//*

//1번째 줄 : 별 n개       
//2번째 줄 : 별 n-1개
//3번째 줄 : 별 n-2개
//n번째 줄 : 별 n-(i-1)개

Console.Write("출력할 피라미드의 줄 : ");
int n = int.Parse(Console.ReadLine());

for  (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n-(i-1); j++)
        Console.Write("*");
    Console.WriteLine();
}