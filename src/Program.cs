Console.WriteLine("How much would you like to Donate?");

var donationAmount = Console.ReadLine();

Console.WriteLine("Calculating covered costs...");

var adjustedDonationAmount = GetDonorCoveredCosts(donationAmount);

Console.WriteLine($"The total donation with costs covered is {adjustedDonationAmount}");

object GetDonorCoveredCosts(object donationAmount)
{
    throw new NotImplementedException();
}
