namespace Blend.Cms12.Models.Pages
{
    [SiteContentType(
       GUID = "08A004A0-3CB6-43C1-A217-5E9094812F90",
       GroupName = Globals.GroupNames.Default)]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    public class HappeningPage : SitePageData
    {
        public virtual string Content {  get; set; }
        public virtual ContentArea ContentArea { get; set; }
    }
}
