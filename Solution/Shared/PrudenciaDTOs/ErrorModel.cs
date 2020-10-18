using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class ErrorModel
    {
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string detail { get; set; }
        public string instance { get; set; }


    }
}
