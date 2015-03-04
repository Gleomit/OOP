namespace HomeworkStaticMembersAndNamespaces
{
    using System;

    public class BitArray
    {
        private byte[] bits;
        private int arrayLength;

        public BitArray(int numberOfBits)
        {
            if (numberOfBits < 1 || numberOfBits > 100000)
            {
                throw new ArgumentException("The number of the bits must be in the range (1 - 100000)!");
            }
            else
            {
                this.bits = new byte[numberOfBits];
                this.arrayLength = numberOfBits;
            }
        }

        public byte this[int index]
        {  
            get 
            {
                if (index < 0 || index >= this.arrayLength)
                {
                    throw new ArgumentOutOfRangeException("The element you are trying to access does not exist!");
                }
                else
                {
                    return bits[index];
                }
            }
            set 
            {
                if (index < 0 || index >= this.arrayLength)
                {
                    throw new ArgumentOutOfRangeException("The element you are trying to access does not exist!");
                }
                else
                {
                    if (value >= 0 && value <= 1)
                    {
                        bits[index] = value;
                    }
                    else
                    {
                        throw new ArgumentException("The bit contains only 0 or 1!");
                    }
                }                   
            }
        }

        public override string ToString()
        {
            int result = 0;
            int increment = 0;
            for (int i = arrayLength - 1; i >= 0;i--)
            {
                result += (this.bits[i] * (int)Math.Pow(2, increment));
                increment++;
            }
            return result.ToString();
        }
    }
}
