using System;

namespace Phase3HTMLForms.Controllers
{
    internal class ResponseCacheAttribute : Attribute
    {
        public int Duration { get; set; }
        public object Location { get; set; }
        public bool NoStore { get; set; }
    }
}