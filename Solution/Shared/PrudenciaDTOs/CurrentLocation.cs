using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{

        public class CurrentLocation
        {
            public string message { get; set; }
            public int timestamp { get; set; }
            public Iss_Position iss_position { get; set; }
        }

        public class Iss_Position
        {
            public string latitude { get; set; }
            public string longitude { get; set; }
        }

   
}
