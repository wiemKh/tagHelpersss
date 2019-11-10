using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testCustomTagHelper.TagHelpers
{
    public static class TestExtensionMethod
    {
        public static string MyExtensionMethod(this object obj, string name)
        {

            var customAttributes = (MyCustomAttribute[])typeof(foo).GetProperty(name).GetCustomAttributes(typeof(MyCustomAttribute), true);






            if (customAttributes.Length > 0)
            {
                var myAttribute = customAttributes[0];
                string value = myAttribute.SomeProperty;
                Console.WriteLine(value);

                return value;

            }
            else
            {
                return null;
            }
            }
    }
}
