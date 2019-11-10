using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace testCustomTagHelper.TagHelpers
{
    public class AppreciateTagHelper : TagHelper
    {
        private
        const string appreciationText = "Great work";

      public  Object obj
        {
            get;
            set;
        }
        public string PersonName
        {
            get;
            set;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //Reflection
            //  var customAttributes = (MyCustomAttribute[])typeof(foo).GetCustomAttributes(typeof(MyCustomAttribute), true);


       /////////     var customAttributes = (MyCustomAttribute[])typeof(foo).GetProperty(nameof(foo.TooltipTitle)).GetCustomAttributes(typeof(MyCustomAttribute), true);




           
         var value=   obj.MyExtensionMethod(PersonName);

         /////////   if (customAttributes.Length > 0)
          /////////////  {
             //////////////   var myAttribute = customAttributes[0];
              /////////  string value = myAttribute.SomeProperty;
                //  string title = $"{PersonName}";

                //  string content = $@"<button  type='button'  class='btn btn-secondary'  data-toggle='tooltip' data-placement='top'  title={value}    >click me </button>";


              //  string content = $@"<button  type='button'  class='btn btn-secondary'      >click me </button>";



                output.TagName = "div";
                output.Attributes.Add("data-toggle", "tooltip");
                output.Attributes.Add("title",  value);

              //  output.Content.SetHtmlContent(content);
         /////////////   }
            //output.TagName = "Appreciation";
            //string message = $"{appreciationText}, {PersonName}";

            //var attribute = new TagHelperAttribute(name: "Label", value: message);
            //output.Attributes.Add(attribute);
            //output.Content.SetContent(message);
            // output.Content.SetHtmlContent($"Date :{ DateTime.Now}");


            
        }
    }
}
