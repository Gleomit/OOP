namespace CommonTypeSystem.StringDisperser
{
    using System;
    using System.Collections;
    
    public class StringDisperser: ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private string theString;
        private string[] theStrings;
        public StringDisperser(params string[] list)
        {
            this.theStrings = list;
            this.theString = string.Join("", list);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (char symbol in this.theString)
            {
                yield return symbol;
            }
        }

        public Object Clone()
        {
            string[] newStrings = new string[this.theStrings.Length];
            Array.Copy(this.theStrings, newStrings, this.theStrings.Length);

            StringDisperser copyStringDisperser = new StringDisperser(newStrings);

            return copyStringDisperser;
        }

        public int CompareTo(StringDisperser stringDisperser)
        {
            return this.theString.CompareTo(stringDisperser.theString);
        }

        public override bool Equals(object obj)
        {
            if (((StringDisperser) obj) == null)
            {
                return false;
            }

            if (((StringDisperser) obj).theString == this.theString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.theString.GetHashCode();
        }

        public override string ToString()
        {
            return this.theString;
        }

        public static bool operator !=(StringDisperser first, StringDisperser second)
        {
            return !Object.Equals(first, second);
        }

        public static bool operator ==(StringDisperser first, StringDisperser second)
        {
            return Object.Equals(first, second);
        }
    }
}
