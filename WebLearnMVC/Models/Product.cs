namespace WebLearnMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageAddress { get; set; } = "";
        //public string CategoryName { get; set; } = "";
        public int CategoryId { get; set; }
        public float Price { get; set; } = 0;
    }
}
