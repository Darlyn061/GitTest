// See https://aka.ms/new-console-template for more information
string PigLatinTranslator(string[] args)
{
    string[] words = args[0].Split(" ");
    string pigLatin = "";
    foreach (string word in words)
    {
        string pigLatinWord = word.Substring(1) + word[0] + "ay";
        pigLatin += pigLatinWord + " ";
    }
    return pigLatin;
}

Console.WriteLine(PigLatinTranslator(new string[] { "Hello World" }));
