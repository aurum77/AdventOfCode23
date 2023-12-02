// See https://aka.ms/new-console-template for more information

string input = Directory.GetCurrentDirectory().ToString() + "/input.txt";
Console.Write(input);

var lines = File.ReadLines(input);
int sum = 0;
char first;
char last;

string strnum;

foreach (var line in lines)
{
    if (line.Where(Char.IsDigit).ToList().Count != 0)
    {
        first = line.Where(Char.IsDigit).ToList().First();
        last = line.Where(Char.IsDigit).ToList().Last();
        strnum = $"{first}{last}";

        sum += int.Parse(strnum);
    }
}

Console.WriteLine(sum);
