// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Добро пожаловать в C#!");
Console.Write("Надеюсь вы ");
Console.Write("постигните все нюансы!!! \n");
Console.WriteLine("И все будет супер гуд!!!");
Console.WriteLine(24.7);

string name = "Tom";
int age = 34;
double height = 1.7;
Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);

Console.Write("Введите свое имя: ");
string? name1 = Console.ReadLine();
Console.WriteLine($"Привет {name1}");

int a = 5;
float b = 2F;
Console.WriteLine(a/b);

/*
int a = 3;
int b = 5;
int c = 40;
int d = c---b*a;          // a=3  b=5  c=39  d=25
int d1 = (c-(--b))*a;     // a=3  b=4  c=40  d=108
Console.WriteLine($"a={a}  b={b}  c={c}  d={d} d1={d1}");
*/
/*
if (a > b) Console.WriteLine(a);

if (a > b)
{
    Console.WriteLine(a);
}

if (a > b) Console.WriteLine(a);
    else Console.WriteLine(a);

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(a);
}

if (a > b)
{
    Console.WriteLine(a);
}
else if (a > 10)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(a);
}

if ((a > b) && (a > 10))
{
    Console.WriteLine(a);
}
*/

/*
int x=3;
int y=2;
 
int z = x < y ? (x+y) : (x-y);
Console.WriteLine(z);   // 1
*/

/*
// Промежуточная версия программы
// Решение нашей задачи
// Подготовка данных
bool isWhiteBreadFresh = false;
ushort whiteBreadPrice = 150;
ushort butterPrice = 230;
float milkFatPercentage = 1.2F; 
ushort milkPrice = 170;
ushort icecreamPrice = 350;

Console.Write("Введите начальную сумму: ");
string? sumString = Console.ReadLine();
short sum = Convert.ToInt16(sumString);

if (isWhiteBreadFresh)
{
    // sum = sum - whiteBreadPrice; // Ошибка соответствия типов
    // sum -= whiteBreadPrice;      // Ошибка соответствия типов
    sum = Convert.ToInt16(sum - whiteBreadPrice); //Или же привести к единому типу int
}

sum = Convert.ToInt16(sum - butterPrice);

if (milkFatPercentage == 1.2F)
{
    sum = Convert.ToInt16(sum - milkPrice);
}

if (sum >= icecreamPrice)
{
    sum = Convert.ToInt16(sum - icecreamPrice);
}

Console.WriteLine($"Остаток суммы {sum}");
*/


/*
// Конечная версия программы
// Решение нашей задачи
// Подготовка данных
bool isWhiteBreadFresh = false;
int whiteBreadPrice = 150;
int butterPrice = 230;
float milkFatPercentage = 1.2F; 
int milkPrice = 170;
int icecreamPrice = 350;

Console.Write("Введите начальную сумму: ");
var sum = Convert.ToInt32(Console.ReadLine());

sum = isWhiteBreadFresh ? sum - whiteBreadPrice : sum;
sum -= butterPrice;
sum = milkFatPercentage == 1.2F ? sum - milkPrice : sum;
sum = sum >= icecreamPrice ? sum - icecreamPrice : sum;  

Console.WriteLine($"Остаток суммы {sum}");
*/


// Идеальная версия программы
// Решение нашей задачи
// Подготовка данных
bool isWhiteBreadFresh = true;
int whiteBreadPrice = 150;
int butterPrice = 230;
float milkFatPercentage = 1.2F;
int milkPrice = 170;
int icecreamPrice = 350;

Console.Write("Введите начальную сумму: ");
var sum = Convert.ToInt32(Console.ReadLine());

if (sum <= 0) 
{
    Console.WriteLine("Сумма не может быть меньше 0");
}
else
{

    if (isWhiteBreadFresh)
    {
        if (sum >= whiteBreadPrice)
        {
            sum -= whiteBreadPrice;
            Console.WriteLine($"Купили свежий батон по цене {whiteBreadPrice}");
        }
        else
        {
            Console.WriteLine("На батон денег не хватает");
        }
    }
    else
    {
        Console.WriteLine("Батон не свежий");
    }

    if (sum >= butterPrice)
    {
        sum -= butterPrice;
        Console.WriteLine($"Купили масло по цене {butterPrice}");
    }
    else
    {
        Console.WriteLine("На масло денег не хватает");
    }

    if (milkFatPercentage == 1.2F) 
    {
        if (sum >= milkPrice)
        {
            sum -= milkPrice;
            Console.WriteLine($"Купили молоко 1.2% по цене {milkPrice}");
        }
        else
        {
            Console.WriteLine("На молоко денег не хватает");
        }
    }
    else
    {
        Console.WriteLine("Молоко не 1.2%");
    }

    if (sum >= icecreamPrice)
    {
        sum -= icecreamPrice;
        Console.WriteLine($"Купили мороженное по цене {icecreamPrice}");
    }
    else
    {
        Console.WriteLine("На мороженное денег не хватает");
    }

    Console.WriteLine($"Остаток суммы {sum}");
}