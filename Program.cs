

Console.WriteLine("Ange en text (kan innehålla siffror, bokstäver och specialtecken) ");
string input = Console.ReadLine();
ProcessText(input);

static void ProcessText(string input)
{
    ulong total = 0;

    for (int start = 0; start < input.Length; start++)
    {
        string foundPart = FindPart(input, start);
        if (foundPart == string.Empty)
            continue;

        ulong tal = ulong.Parse(foundPart);
        total += tal;

        int end = start + foundPart.Length - 1;

        Console.Write(input.Substring(0, start));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(foundPart);
        Console.ResetColor();
        Console.WriteLine(input.Substring(end + 1));
    }

    Console.WriteLine();
    Console.WriteLine("Total = " + total);
}

static string FindPart(string input, int start)
{
    char firstChar = input[start];
    if (!char.IsDigit(firstChar))
        return string.Empty;

    for (int end = start + 1; end < input.Length; end++)
    {
        char lastChar = input[end];
        if (!char.IsDigit(lastChar))
            return string.Empty;

        if (firstChar != lastChar)
            continue;

        int length = end - start + 1;
        return input.Substring(start, length);
    }

    return string.Empty;
}



