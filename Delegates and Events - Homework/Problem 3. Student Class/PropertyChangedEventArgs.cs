namespace StudentClass
{
    using System;

    public class PropertyChangedEventArgs : EventArgs
    {
        public string PropertyName;
        public string OldValue;
        public string NewValue;

        public PropertyChangedEventArgs(string PropertyName, string OldValue, string NewValue)
        {
            this.PropertyName = PropertyName;
            this.OldValue = OldValue;
            this.NewValue = NewValue;
        }

        public PropertyChangedEventArgs()
            : this(null, null, null)
        {

        }
    }
}
