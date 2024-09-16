namespace Blend.Cms12.Models.Pages
{
    [SiteContentType(
    GUID = "5C656AA1-0859-401E-8DF4-0539C6276090",
    GroupName = Globals.GroupNames.Specialized)]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class LendleasePage: SitePageData
    {
            public virtual ContentArea ContentArea { get; set; }
    }
}
