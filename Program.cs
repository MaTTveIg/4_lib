using RandomLib;

int randomNumber = RandomNumber.RandomiseNumber();
Console.WriteLine($"Your random number is {randomNumber}");

int randomNumber2 = RandomNumber.RandomiseInRange(5, 25);
Console.WriteLine($"Your random number in range is {randomNumber2}");

string randomString = RandomString.RandomiseString();
Console.WriteLine($"Your random string is {randomString}");

string randomString2 = RandomString.RandomiseOnlyText(10);
Console.WriteLine($"Your random string of text is {randomString2}");