namespace Blend.Cms12.Models.Pages
{
    [SiteContentType(
    GUID = "cd0fd953-5104-4837-8d59-bab1af36f0d1",
    GroupName = Globals.GroupNames.Specialized)]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class FAQPage : SitePageData
    {
        public virtual string Content { get; set; }    
        public virtual XhtmlString Description { get; set; }
    }
}
