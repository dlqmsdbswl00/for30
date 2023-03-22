//25. 소수 판단하기

Console.Write("정수 입력 : ");
int a = int.Parse(Console.ReadLine());

int i;
for (i = 2; i < a; i++)
{
    if (a % i == 0)
    {
        Console.WriteLine("{0}은 소수가 아닙니다", a); 
        break;
    }
}
if (a == i)
    Console.WriteLine("{0}은 소수입니다", a);