using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    public class DeveloperUrlHandler : ILinkLabelHandler
    {
        private readonly string _url;

        public DeveloperUrlHandler(string url)
        {
            _url = url;
        }

        public void Handle()
        {
            Process.Start(_url);
        }
    }
}
