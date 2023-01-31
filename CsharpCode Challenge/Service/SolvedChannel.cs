using CsharpCode_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CsharpCode_Challenge.Service
{
    public class SolvedChannel
    {
        public static string Solved(Channels channel)
        {
            string channelSolved = channel.Id + "-" + channel.Name;

            if (channel.Favorite)
                channelSolved += "*";

            return channelSolved;
        }
    }
}
