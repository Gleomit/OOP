namespace GenericListVersion
{
    [
    System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct
                        | System.AttributeTargets.Enum | System.AttributeTargets.Method
                        | System.AttributeTargets.Interface)
    ]
    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(int majorVersion, int minorVersion)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        public VersionAttribute(int majorVersion)
            : this(majorVersion, 0)
        {

        }

        public int MajorVersion
        {
            get;
            private set;
        }

        public int MinorVersion
        {
            get;
            private set;
        }
    }
}
