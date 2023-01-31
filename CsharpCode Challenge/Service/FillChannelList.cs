using CsharpCode_Challenge.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCode_Challenge.Service
{
    public class FillChannelList
    {
        public static List<Channels> FillChannelsToList()
        {
            // List of channels were retrieved from https://www.mediacontactspro.com/shop/us-tv-stations-tv-networks-tv-programs-database/
            List<Channels> ChannelList = new List<Channels>();
            ChannelList.Add(new Channels()
            {
                Id = 1,
                Name = "Comcast Corp",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 2,
                Name = "CBS Corp",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 3,
                Name = "NBC Universal Inc",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 4,
                Name = "Univision Communications Inc",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 5,
                Name = "Twentieth Century Fox Film",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 6,
                Name = "Sci-Fi Channel",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 7,
                Name = "Cable News Network LP Lllp",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 8,
                Name = "Bloomberg Business News",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 9,
                Name = "CBS Television City",
                Favorite = false
            });

            ChannelList.Add(new Channels()
            {
                Id = 10,
                Name = "VH-1 Video HITS One",
                Favorite = false
            });

            //Sorting list by name
            ChannelList.Sort((x, y) => x.Name!.CompareTo(y.Name));

            return ChannelList;
        }
    }
}
