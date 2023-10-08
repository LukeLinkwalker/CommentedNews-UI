public class Article
{
    public int Id { get; set; }
    public string ArticleUrl { get; set; } = string.Empty;
    public string ArticleTitle { get; set; } = string.Empty;
    public string ArticleThumbnail { get; set; } = string.Empty;
    public string ThreadUrl { get; set; } = string.Empty;
    public int ThreadComments { get; set; }
    public DateTime ThreadTimestamp { get; set; } = DateTime.MinValue;
}