using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Comments
    {
        public string? Text { get; set; }

        public Comments()
        { 
        }

        public Comments(string text) {
            Text = text;
        }
    }
}
