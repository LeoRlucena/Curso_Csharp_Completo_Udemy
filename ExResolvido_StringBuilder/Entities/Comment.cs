using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExResolvido_StringBuilder.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment() { }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
