using Search;


string Starttekst = "Opret en .NET “console app” 2. I din app skal du implementers en metode med passende datatyper for dens parameter og return type:\r\n• Metoden skal modtag 2 stykker tekst som parameter.\r\n• Metoden skal returner en hel-tal værdi.\r\n• Metodens logik skal udføre en “word count”.\r\n• Metodens 1. stykke tekst som parameter indiker hvilket tekst den skal søge på og tælle.\r\n• Metodens 2. stykke tekst som parameter vil være det tekst (f.ex. en paragraf fra en bog) som metoden skal finde ud af, hvor mange gange det søgte\r\nord forkommer i teksten.\r\n• Det skal være ligegyldigt, om ordet er stavet med stort, småt eller indlejret i andre ord.\r\n3. Konsolen skal implementer indput således når konsollen starter:\r\n1. App spørger brugeren om hvilket ord der skal søges på.\r\n2. Bagefter at brugeren skal angive et stykke tekst hvor der skal fortag søgning i.\r\n4. Konsollen skal implementer en output således\r\n• Konsollen udskriver: Ordet ‘<ord at søge på>’ forkommer {det returneret tal fra metoden} gange.\r\n5. Fremvis din app til underviser:\r\n• Du skal her anvende (med kopi/paste) følgende 2 afsnit fra nedstående link som det stykke tekst hvor der skal fortag søgning i :\r\n• Built-in types and custom types\r\n• Value types and reference types\r\nLink: Microsoft Learn doc som omhandler “type-system”: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/\r\n• Overvej (eventuelt vis), hvordan du sikker dig, at det kode du skrev også er cross-platform så din console app kan køre på Windows,\r\nLinux og Mac.";

Console.Write("Hvilket ord vil du søge på? ");
string ord = Console.ReadLine();
Searcher s = new Searcher(ord, Starttekst);
Console.WriteLine($"Ordet '{ord}' forkommer {s.Count()} gange.");
int antal = s.Count();

if (antal >= 10)
{
    File.WriteAllText("C:\\Users\\nijo22\\source\\repos\\Test\\Test\\resultat2.txt", $"Ordet '{ord}' forkommer {antal} gange.");
    Console.WriteLine("Ordet forkom mere end 10 gange, resultatet er gemt i 'resultat.txt'.");

    Console.ReadKey();
}





















//using Search;
//Console.WriteLine("Type in det ord du vil søge på:");
//string Tekst = Convert.ToString(Console.ReadLine());
//searchtekst s = new searchtekst(Tekst, Starttekst);
//Console.WriteLine(s.ToString());

//Console.ReadKey();

//niclas n = new niclas("Niclas", "Aumre");
//Console.WriteLine(n.Method1());


