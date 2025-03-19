public class Tag
{
    public int TagId { get; set; } // Primary key
    public string Name { get; set; }

    public List<PostTag> PostTags { get; set; } // Navigation property
}