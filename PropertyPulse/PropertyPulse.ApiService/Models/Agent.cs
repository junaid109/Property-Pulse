namespace PropertyPulse.ApiService.Models;

public class Agent
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsPremium { get; set; }
    
    public List<PropertyListing> Listings { get; set; } = [];
}
