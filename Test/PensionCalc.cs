// const int pensionsAlder = 67;


public class PensionCalc
{
    
 const int pensionsAlder = 67;


public Result BeregnPension(DateOnly fodseldato)
    {
        int age = DateTime.Today.Year - fodseldato.Year; 
        string? message = null;
        int yearsUntilPension = pensionsAlder - age;

        if (yearsUntilPension < 5)
        {
            message = "Du skal tjekke din pension opsparing.";
        }
        return new Result
        {
            Age = age,
            YearsUntilPension = yearsUntilPension,
            Message = message
        };
    }

}