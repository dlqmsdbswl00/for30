//18. k의 팩토리얼 구하기 (k! = 1*2*3*4*...k)

Console.Write("k : ");
int k = int.Parse(Console.ReadLine());
int fact = 1;

for (int i = 1; i <= k; i++)
    fact *= i;

Console.WriteLine("k! : {0}", fact);

