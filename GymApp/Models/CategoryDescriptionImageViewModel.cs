namespace GymApp.Models
{
    public class CategoryDescriptionImageViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryInfo { get; set; }
        public double CategoryPrice { get; set; }
        public List<string> CategoryDescriptions { get; set; }
        public List<string> CategoryImages { get; set; }
    }
}
