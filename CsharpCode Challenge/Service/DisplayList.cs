using CsharpCode_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCode_Challenge.Service
{
    public class DisplayList
    {
        public static string ShowList(List<Channels> channels)
        {
            string result = string.Empty;
            foreach (var channel in channels)
            {
                result += SolvedChannel.Solved(channel) + "\r\n";
            }
            return result;
        }
    }
}
