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

Console.WriteLine(input);
Console.WriteLine($"\nСодержит слово 'код': {input.ToLower().Contains("код")}");
Console.WriteLine($"Начинается ли строка с 'Привет': {input.ToLower().StartsWith("привет")}");
Console.WriteLine($"Заканчивается ли строка '!': {input.EndsWith('!')}");

