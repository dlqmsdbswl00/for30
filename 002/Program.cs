//2. while 문을 이용해 1부터 n까지 출력하기

Console.Write("1부터 몇 까지 출력할까요? : ");
int n = int.Parse(Console.ReadLine());
int a = 1;
while (a < n)
{
    a++;
    Console.Write("{0} ", a);
}
