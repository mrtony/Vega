namespace vega.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Make Make { get; set; }

        //Foreign key constraint
        public int MakeId { get; set; }
    }
}