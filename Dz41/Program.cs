List numbers = new List();
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < m; i++) {
numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.WriteLine(numbers.Where(n => n > 0).Count());
Console.ReadKey();
