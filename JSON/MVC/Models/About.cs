using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class About
    {
        public string Coach { get; set; }
        public string Bowl { get; set; }
        public string National { get; set; }

        public About()
        {
            Coach = "Lincoln Riley";
            Bowl = "29-22-1 (.567)";
            National = "7 (1950, 1955, 1956, 1974, 1975, 1985, 2000)";
        }

    }
}