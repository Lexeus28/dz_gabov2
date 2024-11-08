//1
//Console.WriteLine("1.");
//Console.WriteLine("2.7");
//2
//Console.WriteLine("2.");
//Console.WriteLine("50");
//Console.WriteLine("10");
//3
//Console.WriteLine("3.");
//Console.Write("13\n45\n61\n9");
//4
//Console.WriteLine("4.");
//int ch = Convert.ToInt32(Console.ReadLine());
//Console.Write(ch+10);
//5
//Console.WriteLine("5.");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(a * 4);
//6
//Console.WriteLine("6.");
//int r = Convert.ToInt32(Console.ReadLine());
//double p = Math.PI;
//double Dl = 2 * p * r;
//double Pl = r * p * r;
//Console.WriteLine($"Длина окружности: {Dl}");
//Console.WriteLine($"Площадь круга: {Pl}");
//7
//Console.WriteLine("7.");
//double x = Convert.ToDouble(Console.ReadLine());
//double y = Math.Cos(x);
//Console.WriteLine(y);
//8
//Console.WriteLine("8.");
//double a = Convert.ToDouble(Console.ReadLine());
//double b = Convert.ToDouble(Console.ReadLine());
//double h = Convert.ToDouble(Console.ReadLine());
//double Mc = Math.Abs(a - b) / 2;
//double boc = Math.Sqrt(Mc * Mc + h * h);
//Console.WriteLine(boc * 2 + a + b);
//9
//Console.WriteLine("9.");
//Console.WriteLine("Введите стоимость 1 кг конфет");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите стоимость 1 кг печенья");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите стоимость 1 кг яблок");
//int c = Convert.ToInt32(Console.ReadLine());
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//int z = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(a * x + b * y + c * z);
//10
//Console.WriteLine("10.");
//string mt = @"Мир Труд Май
//Мир 
//    Труд
//         Май";
//Console.WriteLine(mt);
//11
//Console.WriteLine("11.");
//try
//{
//    string x = Console.ReadLine().Replace(".", ",");
//    string y = Console.ReadLine().Replace(".", ",");
//    double x1 = Convert.ToDouble(x);
//    double y1 = Convert.ToDouble(y);
//    Console.WriteLine(y1);
//    Console.WriteLine(x1);
//}
//catch (Exception)
//{
//    Console.WriteLine("Введите цифоры, а не буковы");
//}
//12
//Console.WriteLine("12.");
//Console.Write("Выберите фигуру(треугольник, четырехугольник, круг) ");
//string fg = Convert.ToString(Console.ReadLine());
//string op = "123";
//float pr, rad;
//switch (fg)
//{
//    case "треугольник":
//        Console.Write("Введите стороны треугольника ");
//        float[] tr_sides = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
//        Console.Write("Выберите периметр или площадь ");
//        op = Console.ReadLine();
//        pr = tr_sides.Sum() / 2;
//        switch (op)
//        {
//            case "площадь":
//                Console.WriteLine(Math.Sqrt(pr * (pr - tr_sides[0]) * (pr - tr_sides[1]) * (pr - tr_sides[2])));
//                break;
//            case "периметр":
//                Console.WriteLine(pr * 2);
//                break;
//        }
//        break;
//    case "четырехугольник":
//        Console.Write("Введите 2 стороны четырехугольника ");
//        float[] sides = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
//        Console.Write("Выберите периметр или площадь ");
//        op = Console.ReadLine();
//        switch (op)
//        {
//            case "площадь":
//                Console.WriteLine(sides[0] * sides[1]);
//                break;
//            case "периметр":
//                Console.WriteLine(sides.Sum() * 2);
//                break;
//        }
//        break;
//    case "круг":
//        Console.Write("Введите радиус круга ");
//        rad = float.Parse((Console.ReadLine()));
//        Console.Write("Выберите периметр или площадь ");
//        op = Console.ReadLine();
//        switch (op)
//        {
//            case "площадь":
//                Console.WriteLine(Math.Pow(rad, 2) * Math.PI);
//                break;
//            case "периметр":
//                Console.WriteLine(rad * 2 * Math.PI);
//                break;
//        }
//        break;

//}
//13
//Console.WriteLine("13.");
//Console.WriteLine($"Вы ввели число {Console.ReadLine()}");
//14
//Console.WriteLine("14.");
//Console.WriteLine("2 кг");
//Console.WriteLine("13 17");
//15
//Console.WriteLine("15.");
//Random rnd = new Random();

//for (int k = 0; k < 4; k++)
//{
//    Console.WriteLine(rnd.Next());
//}
//16
//Console.WriteLine("16.");
//Console.WriteLine("Введите a");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите b");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите c");
//int c = Convert.ToInt32(Console.ReadLine());
//double D = (Math.Pow(b, 2)-(4*a*c));
//if (D < 0)
//{
//    Console.WriteLine("Дискриминант меньше нуля");
//}
//else
//{
//    if (D > 0)
//    {
//        double x1 = (-1 * b + Math.Sqrt(D))/(2*a);
//        double x2 = (-1 * b - Math.Sqrt(D))/(2 * a);
//        Console.WriteLine($"X1={x1}");
//        Console.WriteLine($"X2={x2}");
//    }
//    else
//    {
//        double x = (-1 * b) / (2 * a);
//        Console.WriteLine($"X={x}");
//    }
//}
//17
//Console.WriteLine("17.");
//Console.WriteLine("Введите первое число ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Среднее арифметическое: {Convert.ToDouble((a + b)) / 2}");
//Console.WriteLine($"Среднее геометрическое: {Math.Sqrt(a*b)}");
//18
//Console.WriteLine("18.");
//Console.WriteLine("Введите координаты первой точки через пробел ");
//float[] t1 = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
//Console.WriteLine("Введите координаты второй точки через пробел ");
//float[] t2 = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
//Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow(t1[0]-t2[0],2) + Math.Pow(t1[1] - t2[1],2))}");
//19
//Console.WriteLine("19.а");
//Console.WriteLine("Введите число a ");
//var a = Console.ReadLine();
//Console.WriteLine("Введите число b ");
//var b = Console.ReadLine();
//Console.WriteLine("Введите число c ");
//var c = Console.ReadLine();
//(a, b, c) = (b,c,a);
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine("19.б");
//Console.WriteLine("Введите число a ");
//var a = Console.ReadLine();
//Console.WriteLine("Введите число b ");
//var b = Console.ReadLine();
//Console.WriteLine("Введите число c ");
//var c = Console.ReadLine();
//(a, b, c) = (c, a, b);
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//20
//Console.WriteLine("20.");
//Console.WriteLine("Введите n ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Полных часов с начала суток прошло: {n / 60 / 60}");
//Console.WriteLine($"Полных минут с начала очередного часа прошло: {(n-(n / 60 / 60)*60*60)/60}");
//Console.WriteLine($"Полных секунд с начала очередной минуты прошло: {(Convert.ToInt32(((Convert.ToDouble((n - (n / 60 / 60) * 60 * 60)) / 60) - ((n - (n / 60 / 60) * 60 * 60) / 60))*60))}");
//21
//Console.WriteLine("21.");
//double k = (543 * 130) / (130 * 130);
//Console.WriteLine(k);
//22
//Console.WriteLine("22.");
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{c % 10 * 100 + (c / 10)}");
//23
//Console.WriteLine("23.");
//Console.WriteLine("Введите n, которое больше 999 ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Число сотен: {n / 100}");
//Console.WriteLine($"Число тысяч: {n/1000}");
//24
//Console.WriteLine("24.");
//Console.WriteLine("Введите четырёзначное число");
//string r = Console.ReadLine();
//char[] b = r.ToArray();
//Console.WriteLine(int.Parse($"{b[3]}{b[2]}{b[1]}{b[0]}"));
//Console.WriteLine(int.Parse($"{b[1]}{b[0]}{b[3]}{b[2]}"));
//Console.WriteLine(int.Parse($"{b[0]}{b[2]}{b[1]}{b[3]}"));
//Console.WriteLine(int.Parse($"{b[2]}{b[3]}{b[0]}{b[1]}"));
//25
//Console.WriteLine("25.");
//int n = Convert.ToInt32(Console.ReadLine());
//int k = n / 100;
//Console.WriteLine((n % 100) * 10 + k);
//26
//Console.WriteLine("26.");
//Console.WriteLine("Введите количество часов ");
//double h = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите количество минут ");
//double m = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите количество секунд ");
//double s = Convert.ToDouble(Console.ReadLine());
//double sec = h * 3600 + m * 60 + s;
//Console.WriteLine($"Часовая стрелка сдвинулась на {sec*0.0083333333} градусов");
//27
//Console.WriteLine("27.");
//Console.WriteLine("Введите угол часовой стрелки в радианах");
//double y = Convert.ToDouble(Console.ReadLine());
//double h = Math.Floor(6 * y);
//double m = (180 * y - 30 * h) * 2;
//double ma = m / 30;

//Console.WriteLine($"Угол минутной стрелки равен {ma:F1} радиан; время - {h:F0}:{m:F0}");
//28
//Console.WriteLine("28.");
//int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//int c = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//if (a <= b)
//{
//    if (a <= c)
//    {
//        Console.WriteLine(a);
//    }
//}
//else
//{
//    if (b <= c)
//    {
//        Console.WriteLine(b);
//    }
//    else
//    {
//        Console.WriteLine(c);
//    }
//}
//29
//Console.WriteLine("29.");
//int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//int c = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//if ((a + b) >= (a + c))
//{
//    if ((a + b) >= (b + c))
//    {
//        if ((b + c) >= (a + c))
//        {
//            Console.WriteLine(b + c);
//        }
//        else
//        {
//            Console.WriteLine(a + c);
//        }
//    }
//    else
//    {
//        Console.WriteLine(a + b);
//    }
//}
//else
//{
//    if ((b+c)>=(a+c))
//    {
//        Console.WriteLine(a + c);
//    }
//    else
//    {
//        if ((b + c) >= (a + b))
//        {
//            Console.WriteLine(b + c);
//        }
//        else
//        {
//            Console.WriteLine(a + b);
//        }
//    }
//}
//30
//Console.WriteLine("30.");
//int x = Convert.ToInt32(Console.ReadLine());
//int kol = 0;
//for (int i = 1; i <= x; i++)
//{
//    if (x%i == 0)
//    {
//        kol++;
//    }
//}
//Console.WriteLine(kol);
//31
//Console.WriteLine("31.");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//int d = Convert.ToInt32(Console.ReadLine());
//for (int i = -100; i <= 100; i++)
//{
//    if ((a * Math.Pow(i, 3) + b * Math.Pow(i, 2) + c * i + d) == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
//32
//Console.WriteLine("32.");
//Console.WriteLine("Введите первое число");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите номер элемента прогрессии");
//int n  = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{a + (b-a) * (n - 1)}");
////33
////Console.WriteLine("33.");
//Console.WriteLine("Вы студент?");
//string p = Console.ReadLine();
//Console.WriteLine("Вы пенсионер?");
//string vz = Console.ReadLine();
//Console.WriteLine("Вы трудоустроены?");
//string rab = Console.ReadLine();
//if (p == "да")
//{
//    if (vz == "да")
//    {
//        Console.WriteLine("Кредит не дадут");
//    }

//    else
//    {
//        if (rab == "нет")
//        {
//            Console.WriteLine("Кредит дадут");
//        }
//        else
//        {
//            Console.WriteLine("Кредит не дадут");
//        }
//    }
//}
//else if (vz == "да")
//{
//    if (rab == "нет")
//    {
//        Console.WriteLine("Кредит дадут");
//    }
//    else
//    {
//        Console.WriteLine("Кредит не дадут");
//    }
//}
//else
//{
//    Console.WriteLine("Кредит не дадут");
//}
//34
//Console.WriteLine("34.");
//Console.WriteLine("Как вас зовут?");
//string Im = Console.ReadLine();
//Console.WriteLine(Im);
//Console.WriteLine($"Привет, {Im}");
//35
//Console.WriteLine("35.");
//Console.ReadLine();
//Console.WriteLine("Как вас зовут?");
//string nm = Console.ReadLine();
//Console.WriteLine($"Привет, {nm}");

//if (Console.ReadLine() == "ты знаешь что-то о тайной комнате?")
//{
//    Console.WriteLine("Да");

//    if (Console.ReadLine() == "можешь рассказать?")
//    {
//        Console.WriteLine("Нет");
//        Thread.Sleep(5000);
//        Console.WriteLine("но могу показать");
//        Console.BackgroundColor = ConsoleColor.Green;
//    }
//}
//36
//Console.WriteLine("36.a");

//Console.WriteLine("36.b");


