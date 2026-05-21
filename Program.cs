Console.WriteLine("Hello, World!");
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);
// subtraction
c = a - b;
Console.WriteLine(c);

// multiplication
c = a * b;
Console.WriteLine(c);

// division
c = a / b;
Console.WriteLine(c);

// WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}


{// additional quotient/remainder example
int aa = 7;
int bb = 4;
int cc = 3;
int dquot = (aa + bb) / cc;
int dremainder = (aa + bb) % cc;
Console.WriteLine($"quotient: {dquot}");
Console.WriteLine($"remainder: {dremainder}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
}


{// double examples

double da = 5;
double db = 4;
double dc = 2;
double d = (da + db) / dc;
Console.WriteLine(d);  
}


{// double examples with more precision
double a2 = 19;
double b2 = 23;
double c2 = 8;
double d2 = (a2 + b2) / c2;
Console.WriteLine(d2);
}

{
   double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}"); 
}

{
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

{
    double da3 = 1.0;
double db3 = 3.0;
Console.WriteLine(da3 / db3);

decimal decC = 1.0M;
decimal decD = 3.0M;
Console.WriteLine(decC / decD);
}

{

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);  

}