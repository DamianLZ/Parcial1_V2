using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_V2.Models
{
    public class Album
    {
        public required string Title { get; set; }
        public int Year { get; set; }
        public required string Cover { get; set; }
    }
}
