//19. for문을 이용해 배열에 10개의 숫자 배정하고 출력하기

int[] a = new int[10];

for (int i = 0; i < 10; i++)
    a[i] = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
    Console.Write(a[i] + " ");
Console.WriteLine();