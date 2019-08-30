using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TexnoGallery
{
    public static class HttpCookieCollectionCodes
    {
        public static string language(this HttpCookieCollection cookies)
        {
            return cookies["language"]?.Value;
        }
    }
}