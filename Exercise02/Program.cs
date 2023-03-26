// Задание 2//
Console.Write("Введите число а: ");
string namber1 = Console.ReadLine();

Console.Write("Введите число b: ");
string namber2 = Console.ReadLine();
int a = int.Parse(namber1);
int b = int.Parse(namber2);

if (a == b * b) {
    Console.WriteLine("yes");
} else {
    Console.WriteLine("no");
}