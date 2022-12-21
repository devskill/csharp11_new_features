// See https://aka.ms/new-console-template for more information

string address_city_state_zip = "184, Mirpur, Dhaka, 1216, Bangladesh";

Console.WriteLine($"Hello, World! from Dev Skill. Welecome to our webinar. We hope you enjoy our webinar.{
    address_city_state_zip}");


var safetyScore = 70;
string message = $"The usage policy for {safetyScore} is {safetyScore switch
{
    > 90 => "Unlimited usage",
    > 80 => "General usage, with daily safety check",
    > 70 => "Issues must be addressed within 1 week",
    > 50 => "Issues must be addressed within 1 day",
    _ => "Issues must be addressed before continued use",
}}";

Console.WriteLine(message);