// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hey welcome to checkout, what was the subtotal?");

var subtotal = Console.ReadLine();

Console.WriteLine("Calculating covered costs...");
var costs = GetDonorCoveredCosts(subtotal);

Console.WriteLine($"The donor covered costs are {costs}");

var total = subtotal + costs;
Console.WriteLine($"Thanks your total is 👋");

object GetDonorCoveredCosts(string? subtotal)
{
    throw new NotImplementedException();
}