namespace Blend.Cms12.Models.Blocks.Start
{
    [SiteContentType(GUID = "2D30341A-4A4F-4604-9CA8-6A093877E443")]

    public class Section4Block : SiteBlockData
    {
        public virtual string Content {  get; set; }
        public virtual ContentArea ContentArea { get; set; }
    }
}
