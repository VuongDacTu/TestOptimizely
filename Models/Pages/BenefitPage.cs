namespace Blend.Cms12.Models.Pages
{
    [SiteContentType(
    GUID = "7e4d9bc3-4e27-4860-b1cc-b702b4afc5ba",
    GroupName = Globals.GroupNames.Specialized)]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class BenefitPage : SitePageData
    {
        public virtual ContentArea ContentArea { get; set; }
    }
}
