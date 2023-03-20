//16. 1~100까지 역수의 합
double rsum = 0;
for (int i = 1; i <= 100; i++)
    rsum += 1.0/i;
Console.WriteLine("1부터 100까지의 역수 합 : {0:F2}", rsum);