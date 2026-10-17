namespace ClassesAndObj.Models;


public class Onboarding
{
    public string CustomerName;
    public DateTime OnboardingDate;

    public Onboarding(string customerName, DateTime onboardingDate)
    {
        CustomerName = customerName;
        OnboardingDate = onboardingDate;
    }


    public void DisplayOnboardingInfo()
    {
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Onboarding Date: {OnboardingDate}");
    }
}