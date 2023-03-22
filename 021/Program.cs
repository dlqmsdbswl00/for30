//21. 10명의 성적을 저장하는 배열 score,
//랜덤으로 정수 생성 후 저장, 출력

Random r = new Random();

int[] score = new int[10];

for (int i = 0; i < 10; i++)
    score[i] = r.Next(101);

foreach (int S in score)
    Console.Write("{0}점 ", S);