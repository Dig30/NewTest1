Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int N = int.Parse(input);
int index = N * (-1);
while (index <= N) {
    Console.Write(index + " ");
    index++;
}
