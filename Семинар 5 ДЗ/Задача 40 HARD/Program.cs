// задача 40 - HARD необязательная. 
// На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
int Input(string mess)
{
    System.Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
bool ExsistTriangle(int a, int b, int c)
{
    bool result = false;
    if ((a + b) > c && (a + c) > b && (b + c) > a)
        result = true;
    return result;
}
void RightTriangle(int a, int b, int c)
{
    if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
        System.Console.WriteLine("Треугольник прямоугольный");
}
void IsoscelesTriangle(int a, int b, int c)
{
    if (a == b || b == c || c == a)
        System.Console.WriteLine("Треугольник равнобедренный");
}
void EquilateralTriangle(int a, int b, int c)
{
    if (a == b && b == c)
        System.Console.WriteLine("Треугольник равносторонний");
}
void TriangleAreaPerimeter(int x, int y, int z)
{
    double a = Convert.ToDouble(x);
    double b = Convert.ToDouble(y);
    double c = Convert.ToDouble(z);
    double p = (a + b + c) / 2;
    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    System.Console.WriteLine($"Площадь треугольника равна {area:F2}");
    System.Console.WriteLine($"Периметр треугольника равен {(p * 2):F2}");
}
void TriangleAngles(int x, int y, int z)
{
    double a = Convert.ToDouble(x);
    double b = Convert.ToDouble(y);
    double c = Convert.ToDouble(z);
    double angleA = (Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180) / Math.PI;
    double angleB = (Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180) / Math.PI;
    double angleC = (Math.Acos((c * c + b * b - a * a) / (2 * c * b)) * 180) / Math.PI;
    System.Console.WriteLine($"Углы треугольника равны {angleA:F2},  {angleB:F2} и {angleC:F2}");
}

int a = Input("Введите первое целое положительное число: ");
int b = Input("Введите второе целое положительное число: ");
int c = Input("Введите третье целое положительное число: ");
if (ExsistTriangle(a, b, c) == false)
    System.Console.WriteLine("Треугольника с такими сторонами не существует");
else
{
    RightTriangle(a, b, c);
    IsoscelesTriangle(a, b, c);
    EquilateralTriangle(a, b, c);
    TriangleAreaPerimeter(a, b, c);
    TriangleAngles(a, b, c);
}