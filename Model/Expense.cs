namespace cryspie.Model
{
    public class Expense
    {
        public long Id { get; set; }
        public long CategoryId { get; set; } 
        public ExpenseCategory Category { get; set; }
        public double Cost { get; set; }
        public string Comment { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
    }
}
