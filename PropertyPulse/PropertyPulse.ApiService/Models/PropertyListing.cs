using Pgvector;

namespace PropertyPulse.ApiService.Models;

public class PropertyListing
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Location { get; set; } = string.Empty;
    public string[] Features { get; set; } = [];
    
    // Using PostgreSQL vector type. 
    // Assuming 1536 dimensions for embeddings (e.g., OpenAI text-embedding-3-small). 
    // Adjust dimension based on actual model used.
    public Vector? DescriptionEmbedding { get; set; }

    public int AgentId { get; set; }
    public Agent? Agent { get; set; }
}
