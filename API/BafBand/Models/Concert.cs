using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BafBand.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Date { get; set; }
        public string Place { get; set; }
    }
}