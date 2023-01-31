using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCode_Challenge.Models
{
    public class Channels
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Favorite { get; set; } = false;
    }
}
