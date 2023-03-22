//22. 4개의 정수를 입력받아 최대 최소 평균 구하기
int[] a = new int[4];
int sum = 0;

for (int i = 0; i < 4; i++)
{
    Console.Write("{0}번째 정수를 입력하세요 : ", i+1);
    a[i] = int.Parse(Console.ReadLine());
}

int max = a[0];
int min = a[0];

for (int j = 0;j < 4; j++)
{
    if (a[j] > max)
        max = a[j];
    if (a[j] < min) 
        min = a[j];
    sum += a[j];
}

Console.WriteLine("최대값 : {0} 최소값 : {1} 평균 : {2}", max, min, sum / 4.0);