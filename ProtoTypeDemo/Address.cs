namespace ProtoTypeDemo
{
    //public partial class Employee : ICloneable
    //{
    //    public object Clone()
    //    {
    //        return this.MemberwiseClone();
    //    }
    //}

    public class Address
    {
        public Address()
        {

        }
        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }

        public string StringCon()
        {
            return string.Format("AddressDetails: Door : {0} "+" StreetNumber : {1} "+" ZipCode : {2} "+" Country : {3}", this.DoorNumber, this.StreetNumber, this.ZipCode, this.Country);
        }
    }
}
