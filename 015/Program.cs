//15. 1부터 100까지 짝수, 홀수의 합
int sum = 0;
int sum2 = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
        sum += i;
    else
        sum2 += i;
}
Console.WriteLine("1부터 100까지의 짝수 합 : {0}", sum);
Console.WriteLine("1부터 100까지의 홀수 합 : {0}", sum2);