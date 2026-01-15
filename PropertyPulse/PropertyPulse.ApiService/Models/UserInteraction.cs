namespace PropertyPulse.ApiService.Models;

public class UserInteraction
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty; // External auth ID (Clerk)
    public int PropertyListingId { get; set; }
    public PropertyListing? PropertyListing { get; set; }
    
    public InteractionType Type { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}

public enum InteractionType
{
    View,
    Save,
    Contact
}
