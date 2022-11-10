{
string input = Console.ReadLine();
bool v = int.TryParse(input, out int n);
{
    List<char> dighits = new();
    dighits = n.ToString().ToCharArray().ToList();

    var ordered_dighits = dighits.OrderByDescending(x => x).ToList();
    double bigest = double.Parse(string.Join("", ordered_dighits));
    Console.WriteLine($"Bigest number is {bigest}");
    double qur = Math.Pow(bigest, 2);
    Console.WriteLine($"Sqr of number is {qur}");
}
// Задание - 2
string input = Console.ReadLine();
bool v = int.TryParse(input, out int n);
{
    List<char> dighits = new();
    dighits = n.ToString().ToCharArray().ToList();
    dighits.RemoveAt(0);
    dighits.RemoveAt(dighits.Count - 1);
    string res = string.Join("", dighits);
    Console.WriteLine($"Result is is {res}");
}
//Задание - 3
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int[] digits = { a, b, c, };
int temp;
for (int i = 0; i < 3; i++)
{
    for (int j = i + 1; j < 3; j++)
    {
        if (digits[i] < digits[j])
        {
            temp = digits[i];
            digits[i] = digits[j];
            digits[j] = temp;
        }
    }
}
int d = digits[1];
Console.WriteLine("Среднее из них ");
return d;
//Задание - 4
string input = Console.ReadLine();

bool v = int.TryParse(input, out int _input_int);
    var dighit = input.ToCharArray().ToList();
    List<char> good_dighit = new();
    foreach (char c in dighit)
    {
        int check = int.Parse(c.ToString());
        if (check % 2 == 0) good_dighit.Add(c);

    }
    if (good_dighit.Count > 0)
        Console.WriteLine($"Result is {string.Join("", good_dighit)}");
    else Console.WriteLine($"Число не содержит четных цифр");
//Задание - 5
int N = Convert.ToInt32(Console.ReadLine());
int k = 0;
int y = N;
while (N != 0)
{
    N = N / 10;
    k++;
}
if (k != 5)
{
    int M = y;
    return M;
}
else
{
    int M = y / 1000 * 100 + y % 100;
    return M;
}
//Задание - 6
int[] a = { 1, 6, 5, 3, 8, 2, 5, 3, 1 };
    int best_count = 0;

    for (int i = 0; i < a.Length; i++)
    {
        if (i == 0) continue;
        if (i == a.Length - 1) continue;

        int _this_int = a[i];
        int _before_int = a[i - 1];
        int _after_int = a[i + 1];

        if (_this_int > _before_int && _this_int > _after_int) best_count++;
    }
    Console.WriteLine($"Таких чисел: {best_count}");
}
