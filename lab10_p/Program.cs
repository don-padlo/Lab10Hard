using System.Text;
using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

string text = "  Строки в C# неизменяемы  ";
string clean = text.Trim();

Console.WriteLine(clean);
Console.WriteLine($"clean {clean.Length}, text {text.Length}");
Console.WriteLine($"{clean[0]} {clean[clean.Length - 1]}");
Console.WriteLine(clean.ToUpper());
Console.WriteLine($"C#: {clean.Contains("C#")} | c#: {clean.Contains("c#")}");
Console.WriteLine(clean.IndexOf("C#"));
Console.WriteLine(clean.Replace("неизменяемы", "удобны"));

Console.WriteLine();
Console.WriteLine(clean.ToUpper());
Console.WriteLine(clean);

Console.WriteLine();
string date = "15.09.2025";

Console.WriteLine($"{date.Substring(0, 2)}\n{date.Substring(3, 2)}\n{date.Substring(6, 4)}");

Console.WriteLine();
string sentence = "  Сегодня   хорошая   погода  ";
string[] a = sentence.Split(' ');
string[] a1 = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"{a.Length}");
Console.WriteLine($"{a1.Length}");
Console.WriteLine();
Console.WriteLine("1 список");
foreach (string words in a){
    Console.WriteLine(words);
}
Console.WriteLine();
Console.WriteLine("2 список");
foreach (string words2 in a1){
    Console.WriteLine(words2);
}

//Мы из строки сделали список,а списки была в 9 практике
Console.WriteLine("\nВведите текст");
string? input = Console.ReadLine();

while (string.IsNullOrWhiteSpace(input)!=false){
    Console.WriteLine("Введите текст");
    input = Console.ReadLine();
}

input = input.Trim();


Console.WriteLine($"\nСодержит слово 'код': {input.ToLower().Contains("код")}");
Console.WriteLine($"Начинается ли строка с 'Привет': {input.ToLower().StartsWith("привет")}");
Console.WriteLine($"Заканчивается ли строка '!': {input.EndsWith('!')}");


Console.WriteLine();
string result = "";

for (int j = 1; j <= 5; j++)
{
    result += j + " ";
}

Console.WriteLine(result);

StringBuilder res_ult = new();

for (int j = 1; j<=5; j++){
    res_ult.Append(j)
    .Append(" ");
}
//+= создаёт новую строку,а старую удаляет.
Console.WriteLine(res_ult);

Console.WriteLine();
string[] students = ["Иван", "Анна", "Пётр"];

StringBuilder report = new();

report.AppendLine("=== ОТЧЁТ ===")
.AppendLine("Группа: 2ИС-1")
.Append("Студентов: ")
.AppendLine($"{students.Length}");
for (int i = 0;i<students.Length;i++){
    report.AppendLine($"{i+1}. {students[i]}");
}

Console.WriteLine(report);


string[] products = ["Хлеб", "Молоко", "Ноутбук"];
double[] prices = [45, 89.5, 65999.99];

Console.WriteLine("№   Товар               Цена");
Console.WriteLine(new string('-',28));
for (int i = 0; i < products.Length; i++){
    string smth = $"{prices[i]:N2}";
    Console.WriteLine($"0{i+1}  {products[i]}{new string(' ',24-products[i].Length-smth.Length)}{smth}");
}

Console.WriteLine();
Console.WriteLine($"{0.256:P0}");
Console.WriteLine($"{255:X}");

Console.WriteLine();
Console.WriteLine("Введите число товаров,которое вам нужно купить: ");
int number = intCheck(Console.ReadLine()!);
StringBuilder check = new();
double[] TS = [0, 45];
check.AppendLine("========== ПОКУПКИ ==========")
.AppendLine("Товар             Кол-во      Цена      Сумма")
.AppendLine(new string('-',45));
for (int i = 0; i <number;i++){
    Console.WriteLine("название,цена,количество: ");
    string NCC = nullCheck(Console.ReadLine());
    NCC = NCC.Trim();
    string[] ncc = NCC.Split(',');
    ncc = autoNullCheck(ncc);
    check.Append(ncc[0])
    .Append($"{new string(' ', 24 - ncc[0].Length - ncc[2].Length)}{ncc[2]}")
    .Append($"{new string(' ', 10 - $"{ncc[1]}:N2".Length)}")
    .Append($"{double.Parse(ncc[1]):N2}")
    .AppendLine($"{new string(' ',11-$"{(int.Parse(ncc[2])*double.Parse(ncc[1])):N2}".Length)}{(int.Parse(ncc[2])*double.Parse(ncc[1])):N2}");TS[0] += (int.Parse(ncc[2]) * double.Parse(ncc[1]));
}
check.Append($"ИТОГО:{new string('-', 39 - $"{TS[0]:N2}".Length)}{TS[0]:N2}");
Console.WriteLine();
Console.WriteLine(check);

int intCheck(string hz){
    while (int.TryParse(hz, out int something)==false){
        Console.Write("\nВведите число: ");
        hz = Console.ReadLine()!;   
    }
    return int.Parse(hz);
}

double doubleCheck(string hz){
    while (double.TryParse(hz, out double something)==false){
        Console.Write("\nВведите дробное число: ");
        hz = Console.ReadLine()!;   
    }
    return double.Parse(hz);
}

string nullCheck(string? hz){
    while(string.IsNullOrWhiteSpace(hz)!=false){
        Console.Write("Введите текст: ");
        hz = Console.ReadLine()!;
    }
    return hz;
}

string[] autoNullCheck(string[] array){
    array[0] = nullCheck(array[0]);
    array[1] = $"{doubleCheck(array[1])}";
    array[2] = $"{intCheck(array[2])}";
    return array;
}