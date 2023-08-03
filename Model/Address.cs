namespace cryspie.Model
{
    public class Address
    {
        public long Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public long PostCode { get; set; }
        public int KinShipId { get; set; }
        public KinShip KinShip { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
    }

}
