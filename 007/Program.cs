//7. 피라미드 (2)
//*****
//****
//***
//**
//*

//1번째 줄 : 별 5개,     공백 0개
//2번째 줄 : 별 4개,     공백 1개
//3번째 줄 : 별 3개,     공백 2개
//i번째 줄 : 별 (5-i)+1, 공백 i-1개

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= (5 - i) + 1; j++)
        Console.Write("*");

    for (int j = 0; j <= (i - 1); j++)
        Console.Write(" ");
    Console.WriteLine();
}
