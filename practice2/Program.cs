// Задание 1
// using System;

// class Student
// {
//     public Student(string f, string d, int n, int[] marks)
//     {
//         this.secondname = f;
//         this.birthday = Convert.ToDateTime(d);
//         this.numberGroup = n;
//         this.estimates = marks;
//     }
//     public string secondname;
//     public DateTime birthday;
//     public int numberGroup;
//     public int[] estimates = new int[5];

//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Фамилия: {secondname}");
//         Console.WriteLine($"Дата рождения: {birthday}");
//         Console.WriteLine($"Номер группы: {numberGroup}");
//         Console.WriteLine($"Успеваемость: {string.Join(", ", estimates)}");
//     }
// }
// class HelloWorld
// {

// public static void Main()
//     {
//         int[] estimates = new int[] { 5, 4, 5, 3, 5 };
//         Student stud1 = new Student("Vasiliev", "08.01.2005", 612, estimates);
//         int numMenu = -1;
//         int numMenu2 = -1;
//         while (numMenu != 0)
//         {
//             Console.WriteLine("Выберите вкладку:\n\n1 - Работа со студентами\n0 - Выход");
//             numMenu = Convert.ToInt32(Console.ReadLine());
//             switch (numMenu)
//             {
//                 case 1:
//                     Console.WriteLine("Выберите вкладку:\n\n1 - Изменение информации\n2 - Вывод информации\n0 - Выход");
//                     numMenu2 = Convert.ToInt32(Console.ReadLine());
//                     switch (numMenu2)
//                     {
//                         case 1:
//                             Console.Write("Введите фамилию: ");
//                             string secondnameChange = Console.ReadLine()!;
//                             stud1.secondname = secondnameChange!;

//                             Console.Write("Введите дату рождения dd.MM.yyyy: ");
//                             DateTime birthdayChange = Convert.ToDateTime(Console.ReadLine()!);
//                             stud1.birthday = birthdayChange;

//                             Console.Write("Введите номер группы: ");
//                             int numberGroupChange = Convert.ToInt32(Console.ReadLine());
//                             stud1.numberGroup = numberGroupChange;
//                             break;
//                         case 2:
//                             stud1.DisplayInfo();
//                             break;
//                     }
//                     break;
//                 case 0:
//                     return;

//                     default:
//                     Console.WriteLine("Выбранной вкладки не существует");
//                     break;
//             }

//         }
//     }
// }

//Задание 2

// using System;
// namespace project2
// {
//     class Train
//     {
//         public Train(string nm, int n, string d)
//         {
//             this.nameTrain = nm;
//             this.numberTrain = n;
//             this.departureTime = Convert.ToDateTime(d);
//         }
//         public string nameTrain = " ";
//         public int numberTrain;
//         public DateTime departureTime;

//         public void DisplayInfo()
//         {
//             Console.WriteLine($"Название пункта назначения: {nameTrain}");
//             Console.WriteLine($"Номер поезда: {numberTrain}");
//             Console.WriteLine($"Время отправления: {departureTime}");
//         }
//     }
//     class HelloWorld
//     {
//         public static void Main()
//         {
//             Train train1 = new Train("Москва", 1, "19.03.2023 23:00:00");
//             Train train2 = new Train("Санкт-Питербург", 2, "20.03.2023 03:00:00");
//             Train train3 = new Train("Кемерово", 3, "21.03.2023 19:00:00");
//             Train train4 = new Train("Томск", 4, "22.03.2023 16:55:00");
//             Train train5 = new Train("Волгоград", 5, "26.03.2023 19:44:00");

//             Console.WriteLine("Введите номер поезда 1-5:");
//             int numTrain = Convert.ToInt32(Console.ReadLine());
//             switch (numTrain)
//             {
//                 case 1:
//                     train1.DisplayInfo();
//                     break;
//                 case 2:
//                     train2.DisplayInfo();
//                     break;
//                 case 3:
//                     train3.DisplayInfo();
//                     break;
//                 case 4:
//                     train4.DisplayInfo();
//                     break;
//                 case 5:
//                     train5.DisplayInfo();
//                     break;
//                 default:
//                     Console.WriteLine("Такого поезда не существует");
//                     return;
//             }
//         }
//     }
// }

//Задание 3

// namespace NumbersTask3
// {
//     class Number
//     {
//         public int num1;
//         public int num2;

//         public void DisplayInfo()
//         {
//             Console.WriteLine($"Первое число: {num1}");
//             Console.WriteLine($"Второе число: {num2}");
//         }
//         public Number(int switchNum1, int switchNum2)
//         {
//             this.num1 = switchNum1;
//             this.num2 = switchNum2;
//         }
//         public int sumNumbers(int a, int b) 
//         {
//             int sumNumbers = a + b;
//             return sumNumbers;
//         }
//         public int GreatestNum(int a, int b)
//         {
//             if (a > b)
//             {
//                 return a;
//             }
//             else 
//             {
//                 return b;
//             }
//         }
//     }
//     class Task3 
//     {
//         static void Main()
//         {
//             Console.Write("Введите первое число: ");
//             int a = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Введите второе число: ");
//             int b = Convert.ToInt32(Console.ReadLine());
//             Number numbers = new Number(a, b);
//             Console.WriteLine("Выберите вкладку:\n\n1 - Вывод чисел\n2 - Сумма чисел\n3 - Наибольшее число\n0 - Ничего");
//             int menu = Convert.ToInt32(Console.ReadLine());
//             switch (menu)
//             {
//                 case 1:
//                     numbers.DisplayInfo();
//                 break;
//                 case 2:
//                     Console.WriteLine($"Сумма: {numbers.sumNumbers(a, b)}");
//                 break;
//                 case 3:
//                     Console.WriteLine($"Наибольшее число: {numbers.GreatestNum(a, b)}");
//                 break;
//                 case 0:
//                 return;
//                 default:
//                     Console.WriteLine("Такой вкладки нет в меню");
//                 return;
//             }
//         }
//     }
// }

//Задание 4

// namespace ValueTask4
// {
//     class Value
//     {
//         public int value;
//         public Value(int checkValue)
//         {
//             this.value = checkValue;
//         }
//         public void DisplayInfo()
//         {
//             Console.WriteLine($"Текущее значение счетчика: {value}");
//         }
//         public void Increment()
//         {
//             value++;
//         }
//         public void Decrement()
//         {
//             value--;
//         }
//     }
//     class Counter1121
//     {
//         static void Main()
//         {
//             Console.WriteLine("Выберите, какое будет значение счетчика:\n\n1 - свое\n2 - значение по умолчанию(10)");
//             int counter = Convert.ToInt32(Console.ReadLine());
//             Value counter1 = new Value(10);
//             switch (counter)
//             {
//                 case 1:
//                     Console.Write("Введите значение: ");
//                     int a = Convert.ToInt32(Console.ReadLine());
//                     counter1.value = a;
//                 break;
//                 case 2:
//                     break;
//                 default:
//                     Console.WriteLine("Ошибка ввода");
//                 return;
//             }
//             Console.WriteLine("Для того что бы добавить к счетчику, напишите: (+1) для того что бы отнять: (-1)\nДля завершения - 0");
//             string menu = "";
//             while (menu != "0")
//             {
//                 Console.WriteLine("+1 или -1?: ");
//                 menu = Console.ReadLine()!;
//                 switch (menu)
//                 {
//                     case "+1":
//                         counter1.Increment();
//                         counter1.DisplayInfo();
//                     break;
//                     case "-1":
//                         counter1.Decrement();
//                         counter1.DisplayInfo();
//                     break;
//                     case "0":
//                         return;
//                     default:
//                         Console.WriteLine("Неверный формат");
//                     return;
//                 }
//             }
//         }
//     }
// }

//Задание 5

// namespace DeleteTask5
// {
//     class Delete
//     {
//         public int myInt;
//         public string myString;

//         public Delete(int value, string strings)
//         {
//             this.myInt = value;
//             this.myString = strings;
//         }
//         public Delete() : this(0, "")
//         {
//         }

//         public int myInt1
//         {
//             get { return myInt; }
//             set { myInt = value; }
//         }
//         public string myString1
//         {
//             get { return myString; }
//             set { myString = value; }
//         }
//         ~Delete()
//         {
//             Console.WriteLine($"Объект удален");
//         }
//     }
//     class Task5
//     {
//         static void Main()
//         {
//             Delete obj1 = new Delete(10, "MyNameIsEgor");
//             Console.WriteLine($"Объект №1 - {obj1.myInt}, {obj1.myString}");

//             Delete obj2 = new Delete();
//             obj1.myInt1 = 45;
//             obj2.myString1 = "HiEgor";

//             Console.WriteLine($"Объект №1 - {obj1.myInt}, {obj1.myString}");
//             Console.WriteLine($"Объект №2 - {obj2.myInt}, {obj2.myString}");

//             obj1 = null;
//             GC.Collect();
//             obj2 = null;
//             GC.Collect();
//         }
//     }
// }