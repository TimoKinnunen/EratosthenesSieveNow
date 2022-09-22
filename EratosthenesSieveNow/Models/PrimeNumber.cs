using SQLite;

namespace EratosthenesSieveNow.Models
{
    [Table("PrimeNumbers")]
    public class PrimeNumberItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Unique]
        public string PrimeNumber { get; set; }
    }
}
