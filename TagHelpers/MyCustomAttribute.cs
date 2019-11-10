using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCustomTagHelper.TagHelpers
{
    [AttributeUsage(AttributeTargets.All)]
    public class MyCustomAttribute : Attribute
    {
        public string SomeProperty { get; set; }

    }
}
