using System; 


    
Console.WriteLine("indtast din fødselsdag: ");
string input = Console.ReadLine(); 
DateOnly birthDate = DateOnly.Parse(input); //formatter string til DateOnly

PensionCalc calc = new PensionCalc(); // Opretter instans af PensionCalc

Result result = calc.BeregnPension(birthDate); // Caller og Gemme Resultatet

Console.WriteLine(result.YearsUntilPension + " år til pension" + " du er " + result.Age + " År Gammle "); //print
Console.WriteLine(result.Message);
