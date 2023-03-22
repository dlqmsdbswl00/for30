//23. 10명의 성적을 받아 성적의 최소 최대 평균값 구하기

Random r = new Random();
int[] a = new int[10];

int sum = 0;

for (int i = 0; i < 10; i++)
    a[i] = r.Next(101);
int min = a[0];
int max = a[0];

for (int i = 0; i < 10; i++)
{
    if (a[i] < min)
        min = a[i];
    if (a[i] > max)
        max = a[i];
    sum += a[i];
}
Console.WriteLine("최대값 : {0} 최소값 : {1} 평균 : {2}", max, min, sum / 10.0);