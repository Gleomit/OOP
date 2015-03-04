namespace CommonTypeSystem.Customer
{ 
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;

        private string permanentAddress;
        private string mobilePhone;
        private string email;

        private List<Payment> payments;

        public Customer(string firstName, string middleName, string lastName, uint id,
            string permanentAddress, string mobilePhone, string email, List<Payment> payments)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.payments = payments;
        }

        public CustomerType CustomerType
        {
            get;
            set;
        }

        public uint ID
        {
            get;
            private set;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Middle name cannot be null or empty.");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email cannot be null or empty.");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mobile phone cannot be null or empty.");
                }
                else
                {
                    this.mobilePhone = value;
                }
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Permanent address cannot be null or empty.");
                }
                else
                {
                    this.permanentAddress = value;
                }
            }
        }

        public string FullName
        {
            get { return string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName); }
        }

        public Object Clone()
        {
            List<Payment> newPayments = new List<Payment>();

            foreach(Payment payment in this.payments)
            {
                newPayments.Add(payment);
            }

            Customer copyCustomer = new Customer(this.FirstName, this.MiddleName, this.LastName, this.ID,
                this.permanentAddress, this.mobilePhone, this.email, newPayments);
            
            return (copyCustomer as Customer);
        }

        public override bool Equals(object obj)
        {
            if ((obj as Customer) == null)
            {
                return false;
            }

            if (((Customer)obj).ID == this.ID)
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
            return this.ID.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("\nFull name - {0}\nID - {1}\nType - {2}\nMobile phone - {3}\nPermanent address - {4}\nEmail - {5}\nPayments:\n{6}\n",
                this.FullName, this.ID, this.CustomerType.ToString(), this.mobilePhone, this.permanentAddress, this.email,
                string.Join("\n", this.payments.Select(payment => payment.ToString()).ToList()));
        }

        public static bool operator !=(Customer first, Customer second)
        {
            return !Object.Equals(first, second);
        }

        public static bool operator ==(Customer first, Customer second)
        {
            return Object.Equals(first, second);
        }

        public int CompareTo(Customer customer)
        {
            if(this.FullName.CompareTo(customer.FullName) == 0)
            {
                return this.ID.CompareTo(customer.ID);
            }
            else
            {
                return this.FullName.CompareTo(customer.FullName);
            }
        }
    }
}
