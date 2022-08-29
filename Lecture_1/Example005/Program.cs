Console.Clear();
// Console.SetCursorPosition(10 ,4);
// Console.WriteLine("+");

int xa = 30, ya = 0,
    xb = 0, yb = 20,
    xc = 60, yc = 20;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("*");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("*");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

int count = 0;
int x = xa, y = ya;

while (count < 10000)
{
    int num = new Random().Next(0, 3);

    if (num == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (num == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (num == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count += 1;
}

Console.SetCursorPosition(xc, yc);