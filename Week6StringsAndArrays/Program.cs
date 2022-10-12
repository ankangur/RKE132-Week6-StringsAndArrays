//string hello = "hello, world! Here I am";
string hello = " we are the champions?";

//1.
int stringLength = hello.Length; // sõne omadus - pikkus (loeb ka tühikuid)
// NB!loeb alates nullist - väärtus on alati ühe võrra väiksem - length +1

//Console.WriteLine(stringLength);

//2.
//int stringLength = hello.Length;

//string trimmedString = hello.Trim(); // Trim - kustutab tühikud enne ja pärast sõne

//Console.WriteLine(trimmedString.Length);

//3.
//int stringLength = hello.Length; // kirjutame muutuja väärtuse ümber ilma tühikuteta

hello = hello.Trim();

//int wordCounter = 1;
//for(int i = 0; i < hello.Length; i++)

//4.
//{
//Console.WriteLine($"{i} symbol in string: {hello[i]}"); //näitab mis asukohal mis täht asub
//}
//Console.WriteLine(hello.Length);

//5.
//if (hello[i] == ' ')
//{
//wordCounter++;
//}
//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words"); //lisame wordCounter + 1 sest ta loeb ühe võrra vähem

//6.
//{
//    if (char.IsWhiteSpace(hello[i])) // kontrollib sümbolit, kas see on tühik või mitte
//                                     // IsWhiteSpacetagastab 2 väärtust - true või false (on tühik või mitte)
//    {
//    wordCounter++;
//    }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words"); //lisame wordCounter + 1 sest ta loeb ühe võrra vähem

//7.

char firstLetter = hello[0];
Console.WriteLine(firstLetter);


hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace ('?', '!'); //mida - millega ma soovin asendada 
                                                         //ToUpper muudab ükskõik mis tähe suureks
                                                         //string tüüpi andmed on immutable - ei saa muuta
firstLetter = hello[0];
Console.WriteLine(firstLetter);
Console.WriteLine(hello);   


