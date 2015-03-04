namespace HomeworkStaticMembersAndNamespaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ElementBuilder
    {
        private string element_tag;
        private string element_content;
        private Dictionary<string, List<string>> element_attributes = new Dictionary<string, List<string>>();
        private string html_element_string;

        public ElementBuilder(string elementName)
        {
            this.Element_Tag = elementName;
            this.html_element_string = this.ToString();
        }

        public void AddAttribute(string attribute, string value)
        {
            if (String.IsNullOrWhiteSpace(attribute) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Neither attribute or value params cannot be null or empty!");
            }
            else
            {
                if (this.element_attributes.ContainsKey(attribute))
                {
                    if (!this.element_attributes[attribute].Contains(value))
                    {
                        this.element_attributes[attribute].Add(value);
                    }
                }
                else
                {
                    this.element_attributes.Add(attribute, new List<string>());
                    this.element_attributes[attribute].Add(value);
                }
                this.html_element_string = this.ToString();
            }
        }

        public void AddContent(string content)
        {
            this.element_content = content;
            this.html_element_string = this.ToString();
        }

        public string Element_Tag
        {
            get { return this.element_tag; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Element tag cannot be null or empty!");
                }
                else
                {
                    this.element_tag = value;
                    this.html_element_string = this.ToString();
                }
            }
        }

        public static string operator *(ElementBuilder element, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Theres no point in multiplying the string by zero or negative number!");
            }
            else
            {
                string returnString = "";
                for (int i = 0; i < value; i++)
                {
                    returnString += element.html_element_string;
                }
                return returnString;
            }
        }

        public override string ToString()
        {
            string returnString = "<" + this.element_tag;
            if (this.element_attributes.Count > 0)
            {
                foreach (string key in this.element_attributes.Keys)
                {
                    returnString += " " + key + "=\"" + String.Join(" ", this.element_attributes[key]) + "\"";
                }
            }
            returnString += (HTMLDispatcher.ContentLess_HTML_Tags.Contains(this.element_tag) 
                ? "/>" : ">" + this.element_content + "</" + this.element_tag + ">");
            return returnString;
        }
    }
}
