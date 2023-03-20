//4. for문을 이용해 1부터 n까지 출력하기

Console.Write("1부터 몇 까지 출력할까요? : ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
    Console.Write("{0} ", i);