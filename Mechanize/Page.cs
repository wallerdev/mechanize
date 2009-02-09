using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Www
{
    public class Page
    {
        public string Html { get; protected set; }
        public string Title 
        {
            get
            {
                return null;
            }
        }

        public Page(string html)
        {
            Html = html;
        }
    }
}
