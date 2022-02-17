namespace Person_Address
{
    class Address
    {

        public int HouseNumber { get; }
        public string Street { get; set; }
        public string Town { get; }
        public string Postcode { get; }

        public Address(int houseNumber, string street, string town, string postcode)
        {
            HouseNumber = houseNumber;
            Street = street;
            Town = town;
            Postcode = postcode;
        }

        public string GetFullAddress()
        {
            return 
                string.Format(
                    "{0}, {1}\n{2}\n{3}",
                    HouseNumber,
                    Street,
                    Town,
                    Postcode);
        }
    }
}
