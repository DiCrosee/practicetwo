//Задание 1

// namespace WorkerTask1
// {
//     class Worker
//     {
//         public Worker(string n, string s, double r, int d)
//         {
//             this.name = n;
//             this.surname = s;
//             this.rate = r;
//             this.days = d;
//         }
//         public string name = "";
//         public string surname = "";
//         public double rate;
//         public int days;

//         public double GetSalary(double rate, int days)
//         {
//             double getSalary = rate * days;
//             return getSalary;
//         }
//     }
//     class Task1 
//     {
//         static void Main()
//         {
//             Console.Write("Введите имя работника: ");
//             string n = Console.ReadLine()!;
//             Console.Write("Введите фамилию работника: ");
//             string s = Console.ReadLine()!;
//             Console.Write("Введите ставку работника: ");
//             double r = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Введите количество отработанных дней работника: ");
//             int d = Convert.ToInt32(Console.ReadLine());

//             Worker worker1 = new Worker(n, s, r, d);

//             Console.Write($"Зарплата {n} {s} составляет {worker1.GetSalary(r, d)} рублей");
//         }   
//     }    
// }


// Задание 2

// namespace WorkerTask2
// {
//     class Worker
//     {
//         public Worker(string n, string s, double r, int d)
//         {
//             this.name = n;
//             this.surname = s;
//             this.rate = r;
//             this.days = d;
//         }
//         private string name = "";
//         private string surname = "";
//         private double rate;
//         private int days;

//         public string Name
//         {
//             get { return name; }
//             set { name = value; }
//         }

//         public string Surname
//         {
//             get { return surname; }
//             set { surname = value; }
//         }

//         public double Rate
//         {
//             get { return rate; }
//             set { rate = value; }
//         }

//         public int Days
//         {
//             get { return days; }
//             set { days = value; }
//         }

//         public double GetSalary()
//         {
//             double getSalary = Rate * Days;
//             return getSalary;
//         }
//     }
//     class Task2 
//     {
//         static void Main()
//         {
//             Console.Write("Введите имя работника: ");
//             string n = Console.ReadLine()!;
//             Console.Write("Введите фамилию работника: ");
//             string s = Console.ReadLine()!;
//             Console.Write("Введите ставку работника: ");
//             double r = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Введите количество отработанных дней работника: ");
//             int d = Convert.ToInt32(Console.ReadLine());

//             Worker worker1 = new Worker(n, s, r, d);

//             Console.Write($"Зарплата {n} {s} составляет {worker1.GetSalary()} рублей");
//         }   
//     }    
// }

//Задание 3

// namespace CalculationTask3
// {
//     class Calculation 
//     {
//         public Calculation(string str)
//         {
//             this.calculationLine = str;
//         }
//         public string calculationLine = "";

//         public void SetCalculationLine(string line)
//         {
//             calculationLine = line;
//         }

//         public void SetLastSymbolCalculationLine(char symbol)
//         {
//             calculationLine += symbol;
//         }

//         public string GetCalculationLine()
//         {
//             return calculationLine;
//         }

//         public char GetLastSymbol()
//         {
//             return calculationLine[calculationLine.Length - 1];
//         }

//         public void DeleteLastSymbol()
//         {
//             calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
//         }
//     }
//}