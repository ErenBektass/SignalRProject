namespace Project.ENTITIES.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        //Relational Properties
        public List<Product> Products { get; set; }
    }
}
