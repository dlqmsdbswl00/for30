//6. n줄의 피라미드 (1)
//*
//**
//***
//****
//*****
//...n

Console.Write("출력할 피라미드의 줄 : ");
int star = int.Parse(Console.ReadLine());

for (int i = 1; i <= star; i++)
{
    for (int j = 0; j < i; j++)
        Console.Write("*");
    Console.WriteLine();
}