namespace cryspie.Model
{
    public class FamilyMember
    {
        public long Id { get; set; }
        public long KinShipId { get; set; }
        public KinShip KinShip { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
    }

}
