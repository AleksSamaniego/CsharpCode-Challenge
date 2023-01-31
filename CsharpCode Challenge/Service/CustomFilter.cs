using CsharpCode_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCode_Challenge.Service
{
    public class CustomFilter
    {
        public static string ShowFavoritesWithFilter(List<Channels> channels, string filter)
        {
            string result = string.Empty;
            var listByFavorite = channels.Where(x => x.Favorite);
            var listByFilter = channels.Where(x => x.Name!.ToLower().Contains(filter));
            foreach (var channel in listByFilter)
            {
                result += SolvedChannel.Solved(channel) + "\r\n";
            }
            return result;
        }
    }
}
