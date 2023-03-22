//26. 배열에 10개의 정수를 저장하고 짝수만 출력

int[] a = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("{0}번째 정수를 입력하세요 : ", i + 1);
    a[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
	if (a[i] % 2 == 0)
        Console.Write("{0} ", a[i]);
}