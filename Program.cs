/*
Console.WriteLine("Skriv in en mening för att se om den är ett palindrom");

var ord = Console.ReadLine().ToLower();

var nyttOrd = String.Empty;
var reverse = String.Empty;

Console.WriteLine();

for (var i = 0; i < ord.Length; i++)
{
    var bokstav = ord[i].ToString();
    if (bokstav != " " && bokstav != ".")
        nyttOrd += bokstav;
}

for (var i = nyttOrd.Length - 1; i >= 0; i--)
{
    reverse += nyttOrd[i].ToString();
}

Console.WriteLine(nyttOrd);
Console.WriteLine(reverse);

if (nyttOrd.Equals(reverse, StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("samma");
}
else
{
    Console.WriteLine("inte samma");
}
*/



string Ord = Console.ReadLine().ToLower();
string copy = "";

Console.WriteLine(Ord);

foreach (var letter in Ord)
{
    if (letter != '.' && letter != ' ' && letter != ',' && letter != '?')
    {
        copy += letter;
    }
}
var reverse = string.Empty;

for (int i = copy.Length - 1; i >= 0; i--)
{
    reverse += copy[i]; // reverse = reverse + copy[i]

}

Console.WriteLine(copy);

if (copy == reverse)
{
    Console.WriteLine("Detta är ett palindrom");
}
else
{
    Console.WriteLine("Detta är inte ett palindrom");
}