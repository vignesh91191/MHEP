
namespace Domain.Entities
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Address other = (Address)obj;
            return Street == other.Street && City == other.City && State == other.State && ZipCode == other.ZipCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Street, City, State, ZipCode);
        }
    }
}
