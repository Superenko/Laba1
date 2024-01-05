using Labaa1;

GameAccount firstPlayer = new GameAccount("Rost");
GameAccount secondPlayer = new GameAccount("Kostya");

firstPlayer.WinGame(secondPlayer, DateTime.Now, 1);
firstPlayer.LoseGame(secondPlayer, DateTime.Now, 15);
firstPlayer.LoseGame(secondPlayer, DateTime.Now, 7);
firstPlayer.WinGame(secondPlayer, DateTime.Now, 4);
firstPlayer.WinGame(secondPlayer, DateTime.Now, 1);

secondPlayer.WinGame(firstPlayer, DateTime.Now, 3);
secondPlayer.WinGame(firstPlayer, DateTime.Now, 1);
secondPlayer.WinGame(firstPlayer, DateTime.Now, 6);
secondPlayer.LoseGame(firstPlayer, DateTime.Now, 4);
secondPlayer.LoseGame(firstPlayer, DateTime.Now, 8);


try
{
    firstPlayer.LoseGame(secondPlayer, DateTime.Now, 7);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Error!");
    Console.WriteLine(e.ToString());
    return;
}

Console.WriteLine(firstPlayer.GetStats());
Console.WriteLine(secondPlayer.GetStats());
Console.WriteLine($"{firstPlayer.UserName}'s Rating: " + firstPlayer.CurrentRating.ToString());
Console.WriteLine($"{secondPlayer.UserName}'s Rating: " + secondPlayer.CurrentRating.ToString());
