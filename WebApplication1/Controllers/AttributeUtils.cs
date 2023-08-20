using System;

namespace WebApplication1.Controllers
{
    public class CodeAttribute : Attribute
    {
        internal CodeAttribute(string code)
        {
            Code = code;
        }
        public string Code { get; private set; }
    }
}
