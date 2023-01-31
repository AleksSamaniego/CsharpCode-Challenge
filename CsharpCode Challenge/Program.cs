using CsharpCode_Challenge.Models;
using CsharpCode_Challenge.Service;
using System.Collections.Immutable;

List<Channels> ChannelList;

Default();

while (true)
{
    // Reading action
    string action = Console.ReadLine();

    if (int.TryParse(action, out int channelId))
    {
        AddRemoveFavorite.Favorite(ChannelList, channelId);
    }
    else
    {
        if (action == "list")
        {
            Console.WriteLine(DisplayList.ShowList(ChannelList));
        }
        else if (action == "favorites")
        {
            Console.WriteLine(DisplayFavorites.ShowFavoritesOnly(ChannelList));
        }
        else if (action!.Contains('*'))
        {
            string[] filter = action.Split("*");
            Console.WriteLine(CustomFilter.ShowFavoritesWithFilter(ChannelList, filter[1].Trim()));
        }
        else if (action == "clean")
        {
            Default();
        }
        else if (action == "exit")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("That command was not recognized, please try again.");
            Console.WriteLine("You can use following commands:");
            Console.WriteLine("list - To display all channels");
            Console.WriteLine("favorites - To display all your favorite channels");
            Console.WriteLine("clean - To clear current window and set list to default");
            Console.WriteLine("exit - To quit the console");
            Console.WriteLine("favorite * ChannelName - To filter by Favorite and Channel Name");
        }
    }
}



void Default()
{
    Console.Clear();
    //Fill list of channels
    ChannelList = FillChannelList.FillChannelsToList();
    // Welcome msg
    Console.WriteLine("## C# Code challenge\r\n## Part 01 - TV Shows list");
    Console.WriteLine("Welcome to your TV!\r\nWhat would you like to do?\r\n");
}

