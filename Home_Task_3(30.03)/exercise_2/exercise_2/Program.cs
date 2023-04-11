using exercise_2;
// Домовлялись що буде ще малюнок діаграми! Я його не знайшла.
while (true)
{
    Console.WriteLine("Enter string to work with or input nothing to finish the program");
    var workString = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(workString)) break;

    Console.WriteLine($"number of words that start with capital letter: {workString!.CapitalWordsAmount()}");

    Console.WriteLine();
    Console.WriteLine("input string, which second occurance index you want to find:");
    var secondOccuranceString = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(secondOccuranceString)) continue;
    var secondIndex = workString.SecondIndexOf(secondOccuranceString);

    if (secondIndex is null) Console.WriteLine("there is no second occurance of this substring");
    else Console.WriteLine($"index of second occurance: {secondIndex}");

    Console.WriteLine();
    Console.WriteLine("input replacer for strings with doubled letters:");
    var replacer = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(replacer)) continue;

    Console.WriteLine($"string with replaced words: {workString.ReplaceDoubleLetters(replacer)}");

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}
