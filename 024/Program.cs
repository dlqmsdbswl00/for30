//24. 100까지의 소수 출력

using System.Data;
using System.Globalization;

int sosu;

for (int i = 0; i < 100; i++)
{
    for (sosu = 2; sosu < i; sosu++)
    {
        if (i % sosu == 0)
            break;
    }
    if (sosu == i)
        Console.Write("{0} ", sosu);
}
