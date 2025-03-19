public class BlogSettings
{
    public int BlogSettingsId { get; set; } // Primary key
    public string Theme { get; set; }
    public bool ShowComments { get; set; }

    public int BlogId { get; set; } // Foreign key to Blog
    public Blog Blog { get; set; } // Navigation property to Blog
}