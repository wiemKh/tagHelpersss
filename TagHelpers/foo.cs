using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCustomTagHelper.TagHelpers
{

    public class foo
    {
        
        [MyCustomAttribute(SomeProperty = "wima")]

        public string TooltipTitle { get; set; }

    }
}
