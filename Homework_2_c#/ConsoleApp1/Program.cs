void Shuffle1(string[] cavablar1)
{
    Random random = new Random();

    for (int i = cavablar1.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);
        string temp = cavablar1[i];
        cavablar1[i] = cavablar1[j];
        cavablar1[j] = temp;
    }
}

void Shuffle2(string[] cavablar2)
{
    Random random = new Random();

    for (int i = cavablar2.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);
        string temp = cavablar2[i];
        cavablar2[i] = cavablar2[j];
        cavablar2[j] = temp;
    }
}

void Shuffle3(string[] cavablar3)
{
    Random random = new Random();

    for (int i = cavablar3.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);
        string temp = cavablar3[i];
        cavablar3[i] = cavablar3[j];
        cavablar3[j] = temp;
    }
}

void ShuffleRand(int[] arr)
{
    Random random = new Random();

    for (int i = arr.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}

int xal = 0;

string sual1 = "Azerbaycanin paytaxti haradir?";
string cavab1_1 = "Baki";
string cavab1_2 = "Naxcivan";
string cavab1_3 = "Gence";
string dogru1 = "a";

string[] cavablar1 = { cavab1_1, cavab1_2, cavab1_3 };
string[] suallar1 = { sual1 };
string[][] question1 = { suallar1, cavablar1 };

Shuffle1(cavablar1);

void showSual1()
{
    int say = 1;

    for (int i = 0; i < question1.Length; i++)
    {
        for (int j = 0; j < question1[i].Length; j++)
        {
            if (i == 0)
            {
                Console.WriteLine(question1[i][j]);
            }

            else if (say == 1)
            {
                Console.Write("a) ");
                Console.WriteLine(question1[i][j]);

                if (question1[i][j] == "Baki")
                {
                    dogru1 = "a";
                }

                say++;
            }

            else if (say == 2)
            {
                Console.Write("b) ");
                Console.WriteLine(question1[i][j]);

                if (question1[i][j] == "Baki")
                {
                    dogru1 = "b";
                }
                say++;
            }

            else if (say == 3)
            {
                Console.Write("c) ");
                Console.WriteLine(question1[i][j]);

                if (question1[i][j] == "Baki")
                {
                    dogru1 = "c";
                }

                say++;
            }
        }
    }

}

string sual2 = "2022ci ilde Dunya Cempionu hansi olke olmusdur?";
string cavab2_1 = "Brazilya";
string cavab2_2 = "Argentina";
string cavab2_3 = "Almanya";
string dogru2 = "a";

string[] cavablar2 = { cavab2_1, cavab2_2, cavab2_3 };
string[] suallar2 = { sual2 };
string[][] question2 = { suallar2, cavablar2 };

Shuffle2(cavablar2);

void showSual2()
{
    int say = 1;

    for (int i = 0; i < question2.Length; i++)
    {
        for (int j = 0; j < question2[i].Length; j++)
        {
            if (i == 0)
            {
                Console.WriteLine(question2[i][j]);
            }

            else if (say == 1)
            {
                Console.Write("a) ");
                Console.WriteLine(question2[i][j]);

                if (question2[i][j] == "Argentina")
                {
                    dogru2 = "a";
                }

                say++;
            }

            else if (say == 2)
            {
                Console.Write("b) ");
                Console.WriteLine(question2[i][j]);

                if (question2[i][j] == "Argentina")
                {
                    dogru2 = "b";
                }

                say++;
            }

            else if (say == 3)
            {
                Console.Write("c) ");
                Console.WriteLine(question2[i][j]);

                if (question2[i][j] == "Argentina")
                {
                    dogru2 = "c";
                }

                say++;
            }
        }
    }

}

string sual3 = "Aydin xirdalanli necenci ilde rehmete gedib?";
string cavab3_1 = "2019";
string cavab3_2 = "2018";
string cavab3_3 = "2017";
string dogru3 = "a";

string[] cavablar3 = { cavab3_1, cavab3_2, cavab3_3 };
string[] suallar3 = { sual3 };
string[][] question3 = { suallar3, cavablar3 };

Shuffle3(cavablar3);
void showSual3()
{
    int say = 1;

    for (int i = 0; i < question3.Length; i++)
    {
        for (int j = 0; j < question3[i].Length; j++)
        {
            if (i == 0)
            {
                Console.WriteLine(question3[i][j]);
            }

            else if (say == 1)
            {
                Console.Write("a) ");
                Console.WriteLine(question3[i][j]);

                if (question3[i][j] == "2019")
                {
                    dogru3 = "a";
                }


                say++;
            }

            else if (say == 2)
            {
                Console.Write("b) ");
                Console.WriteLine(question3[i][j]);

                if (question3[i][j] == "2019")
                {
                    dogru3 = "b";
                }

                say++;
            }

            else if (say == 3)
            {
                Console.Write("c) ");
                Console.WriteLine(question3[i][j]);

                if (question3[i][j] == "2019")
                {
                    dogru3 = "c";
                }

                say++;
            }
        }
    }
}


int[] arr = { 1, 2, 3 };
ShuffleRand(arr);

int say = 1;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 1)
    {
        if (say == 1)
        {
            Console.Write("1) ");
        }

        else if (say == 2)
        {
            Console.Write("2) ");
        }

        else if (say == 3)
        {
            Console.Write("3) ");
        }
        say++;

        showSual1();

        Console.Write("Cavab: ");
        string answer = Console.ReadLine();

        if (answer == dogru1)
        {
            Console.WriteLine("Dogrudur");
            Console.ForegroundColor = ConsoleColor.Blue;

            xal += 10;
        }

        else
        {
            Console.WriteLine("Yanlisdir");
            Console.ForegroundColor = ConsoleColor.Red;
            xal -= 10;
        }

        Console.WriteLine();
    }

    else if (arr[i] == 2)
    {
        if (say == 1)
        {
            Console.Write("1) ");
        }

        else if (say == 2)
        {
            Console.Write("2) ");
        }

        else if (say == 3)
        {
            Console.Write("3) ");
        }
        say++;

        showSual2();

        Console.Write("Cavab: ");
        string answer = Console.ReadLine();

        if (answer == dogru2)
        {
            Console.WriteLine("Dogrudur");
            Console.ForegroundColor = ConsoleColor.Blue;

            xal += 10;
        }

        else
        {
            Console.WriteLine("Yanlisdir");
            Console.ForegroundColor = ConsoleColor.Red;
            xal -= 10;
        }

        Console.WriteLine();
    }

    else if (arr[i] == 3)
    {
        if (say == 1)
        {
            Console.Write("1) ");
        }

        else if (say == 2)
        {
            Console.Write("2) ");
        }

        else if (say == 3)
        {
            Console.Write("3) ");
        }
        say++;

        showSual3();

        Console.Write("Cavab: ");
        string answer = Console.ReadLine();

        if (answer == dogru3)
        {
            Console.WriteLine("Dogrudur");
            Console.ForegroundColor = ConsoleColor.Blue;
            xal += 10;
        }

        else
        {
            Console.WriteLine("Yanlisdir");
            Console.ForegroundColor = ConsoleColor.Red;
            xal -= 10;
        }

        Console.WriteLine();
    }
}
if (xal >= 0)
{
    Console.WriteLine("Toplandigin xal: " + xal);
}

else
{
    Console.WriteLine("Topladigin xal: 0");
}

Console.ResetColor();