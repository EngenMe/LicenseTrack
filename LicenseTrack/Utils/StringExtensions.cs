﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseTrack.Utils
{
    public static class StringExtensions
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}
