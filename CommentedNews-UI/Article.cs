public class Article
{
    public int Id { get; set; }
    public string ArticleUrl { get; set; }
    public string ArticleTitle { get; set; }
    public string ArticleThumbnail { get; set; }
    public string ThreadUrl { get; set; }
    public int ThreadComments { get; set; }
    public DateTime ThreadTimestamp { get; set; }
}