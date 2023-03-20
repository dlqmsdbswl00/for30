//17. x의 y승 구하기
//x의 y승 x를 y번 곱하기

Console.WriteLine("x의 y승 구하기");
Console.Write("x 입력 : ");
int x = int.Parse(Console.ReadLine());
Console.Write("y 입력 : ");
int y = int.Parse(Console.ReadLine());

int exp = 1;

for (int i = 0; i < y; i++)
    exp *= x;
Console.WriteLine("x의 y승 : {0}", exp);