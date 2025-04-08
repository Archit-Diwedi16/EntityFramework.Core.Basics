public class Blog
{
    public int BlogId { get; set; } // Primary key
    public string Title { get; set; }
    public string Url { get; set; }
    public BlogSettings blogSettings {get;set;}

    public List<Post> Posts { get; set; } // Navigation property for posts
}