
OperatorExamples();

void OperatorExamples()
{
    int width = 3;
    width++;
    int height = 2;
    int area = width * height;
    Console.WriteLine(area); //6


    int p = 2;
    for (int q = 2; q < 32; q = q*2)
    {
        while(p<q)
        {
            p = p * 2;
        }
        q = p - q;
    }

    while (area < 50)
    {
        height++;
        area = width * height;
    }
    do
    {
        width--;
        area = width * height;
    } while (area < 25);

    string result = "The area";
    result = result + " is " + area;
    Console.WriteLine(result); //The area is 6

    bool truthValue = true;
    Console.WriteLine(truthValue); //true

    TryAnIf();
    TrySomeLoops();
    TryAnIfElse();

    void TryAnIf()
    {
        int someValue = 4;
        string name = "Bobbo Jr.";
        if ((someValue == 3) && (name == "Joe"))
        {
            Console.WriteLine("x is 3 and the name is Joe");
        }
        Console.WriteLine("this line runs no matter what");
    }

    void TryAnIfElse()
    {
        int x = 5;
        if (x == 10)
        {
            Console.WriteLine("x must be 10");
        }
        else
        {
            Console.WriteLine("x isn’t 10");
        }
    }

    void TrySomeLoops()
    {
        int count = 0;

        while (count < 10)
        {
            count = count + 1;
        }

        for (int i = 0; i < 5; i++)
        {
            count = count - 1;
        }

        Console.WriteLine("The answer is " + count);
    }

}