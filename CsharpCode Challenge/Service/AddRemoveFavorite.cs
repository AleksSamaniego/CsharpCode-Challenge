using CsharpCode_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCode_Challenge.Service
{
    internal class AddRemoveFavorite
    {
        public static List<Channels> Favorite(List<Channels> List, int Id)
        {
            var channel = List.Single(x => x.Id == Id);
            channel.Favorite = channel.Favorite ? false : true;
            return List;
        }
    }
}
