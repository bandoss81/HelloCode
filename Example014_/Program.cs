// как не надо писать код.
/*
//пример 1
double a = 1, b = -26, c = 120;
var d = b * b - 4 * a *c;
double x1 = (-b + Math.Sqrt(d)) / (2 * a);
double x2 = (-b + Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

//пример 2

a = 2; b = 1; c = -3;
d = b * b - 4 * a *c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b + Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

//пример 3

a = 1; b = 1; c = -6;
d = b * b - 4 * a *c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b + Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

// лучше так.
public Roots Solve(double a, double b, double c)
{
    var d = b * b - 4 * a * c;
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b + Math.Sqrt(d)) / (2 * a); 
    return new Roots { x1 = x1, x2 = x2 };
}
*/
// в случайных точках консоли вывести случайные числа
/*
Random r = new Random();
Console.CursorVisible = false;
while (true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
        );
    Console.Write(r.Next(10));
    Thread.Sleep(100);    
}
*/
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7) "
              .Replace("(", "")
              .Replace(")", "")
              ;
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))
                .Where(e => e.x % 2 ==0)
                .Select(point => (point.x * 10, point.y +10))
                .ToArray();

for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    
}

// Нотации:
// * Hungarian notation
// * CamelCase notation
// * PascalCase notation

// Еще:
// * Придерживаеися Code Convention, используемый в проекте.
// * Про коментарии
// * нужно всегда проводить внутреннюю декомпозицию
// * чем больше методов/функций, тем лучше, ибо это логическая
//   группировка маленького кусочка кода - выше читаемость.
// * больше количество циклов и условий - плохо, снижается читаемость
// * нужно писать тестируемый код, писать сами тесты сразу
// * внимательно следить за входными данными, особенно за теми, которые задает юзер
// * чаще задавайте себе вопрос : "как упростить то, что написанно?"

// И еще:
// * Придерживаться SOLID
// * Не использовать антипаттерны
// * Использовать паттерны
// * Писать тесты
// * Придерживаться Code Convention