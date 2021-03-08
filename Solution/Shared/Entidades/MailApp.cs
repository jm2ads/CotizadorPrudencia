using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.Entidades
{
    public class MailApp
    {
        public string Subject { get; set; }

        public string Body { get; set; }
        public string To { get; set; }
        public string Bcc { get; set; }
    }
}
