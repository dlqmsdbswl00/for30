//29. 1~10까지 2진수 출력

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("{0}", Convert.ToString(i, 2).PadLeft(8, '0'));
}