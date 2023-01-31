using CsharpCode_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCode_Challenge.Service
{
    public class DisplayFavorites
    {
        public static string ShowFavoritesOnly(List<Channels> channels)
        {
            string result = string.Empty;
            var listFiltered = channels.Where(x => x.Favorite);
            foreach (var channel in listFiltered)
            {
                result += SolvedChannel.Solved(channel) + "\r\n";
            }
            return result;
        }
    }
}
