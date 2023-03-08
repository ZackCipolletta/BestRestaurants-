namespace RestaurantCuisine.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Author { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
  }
}