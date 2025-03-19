public class Post
{
    public int PostId { get; set; } // Primary key
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishDate { get; set; }

    public int BlogId { get; set; } // Foreign key to Blog
    public Blog Blog { get; set; } // Navigation property to Blog
}