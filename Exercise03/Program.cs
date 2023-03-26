// Задание 3//
Console.WriteLine("Введите день недели: ");
string input = Console.ReadLine();
int namber = int.Parse(input);
if (namber == 1) {
    Console.WriteLine("Понедельник");
} else if (namber == 2) {
    Console.WriteLine("Вторник");
} else if (namber == 3) {
    Console.WriteLine("Среда");
} else if (namber == 4) {
    Console.WriteLine("Четверг");
} else if (namber == 5) {
    Console.WriteLine("Пятница");
} else if (namber == 6) {
    Console.WriteLine("Суббота");
} else if (namber == 7) {
    Console.WriteLine("Воскресение");
} else {
    Console.WriteLine("Нет такого дня!");
}

