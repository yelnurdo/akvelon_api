namespace BookshelfApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Year {get; set; }
        public decimal Price { get; set; }
    }
}
