namespace HomeworkStaticMembersAndNamespaces
{
    using System;
    using System.Collections.Generic;

    public static class HTMLDispatcher
    {
       public static string[] ContentLess_HTML_Tags = { "img", "input", "hr", "br" };

       public static ElementBuilder CreateImage(string image_source, string alt, string title)
       {
           ElementBuilder element = new ElementBuilder("img");
           element.AddAttribute("src", image_source);
           element.AddAttribute("alt", alt);
           element.AddAttribute("title", title);
           return element;
       }
       public static ElementBuilder CreateURL(string url, string title, string text)
       {
           ElementBuilder element = new ElementBuilder("a");
           element.AddAttribute("href", url);
           element.AddAttribute("title", title);
           element.AddContent(text);
           return element;
       }
       public static ElementBuilder CreateInput(string input_type, string name, string value)
       {
           ElementBuilder element = new ElementBuilder("input");
           element.AddAttribute("type", input_type);
           element.AddAttribute("name", name);
           element.AddAttribute("value", value);
           return element;
       }
    }
}
