using Lab13;

int number = 1423;

Console.WriteLine($"Number {number} reversed is: {number.Reverse()}");
Console.WriteLine($"Number of digits in {number} is: {number.NumberOfDigits()}");

string text = "H-e+l_l*o c_#";
Console.WriteLine($"Text {text} after removing special chars is {text.RemoveSpecialCharacters()}");

IEnumerable<int> numbers = new List<int>() { 3, 4, 18, 5, 6 };
Console.WriteLine($"Max number of list is {numbers.GetMaxInCollection()}");

Console.WriteLine($"Max of text list is {text.GetMaxInCollection()}");
