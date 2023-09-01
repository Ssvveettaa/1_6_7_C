// 1_6_7_C001_RecursionString:
// Собрать строку с числами от (a) до (b), где (a ≤ b).

string NumbersForAscending(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec1Ascending(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec1Ascending(a + 1, b);
    else return String.Empty; // Условие окончания рекурсии: вернуть пустую строку.
}

string NumbersRec2Ascending(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec2Ascending(a + 1, b);
    else return $"{a} "; // На один вызов рекурсии меньше.
}

// Собрать строку с числами от (a) до (b), где (a ≥ b).

string NumbersForDescending(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec1Descending(int a, int b)
{
    if (a <= b) return NumbersRec1Descending(a + 1, b) + $"{a} ";
    else return String.Empty; // Условие окончания рекурсии: вернуть пустую строку.
}

string NumbersRec2Descending(int a, int b)
{
    if (a < b) return NumbersRec2Descending(a + 1, b) + $"{a} ";
    else return $"{a} "; // На один вызов рекурсии меньше.
}

Console.WriteLine(NumbersForAscending(1, 5));  // 1 2 3 4 5
Console.WriteLine(NumbersRec1Ascending(1, 5)); // 1 2 3 4 5
Console.WriteLine(NumbersRec2Ascending(1, 5)); // 1 2 3 4 5
Console.WriteLine();
Console.WriteLine(NumbersForDescending(5, 1));  // 5 4 3 2 1
Console.WriteLine(NumbersRec1Descending(1, 5)); // 5 4 3 2 1
Console.WriteLine(NumbersRec2Descending(1, 5)); // 5 4 3 2 1
