public class Tag
{
    public int TagId { get; set; } // Primary key
    public string TagName { get; set; }

    public List<PostTag> PostTags { get; set; } // Navigation property
}