using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Pages
{
    [SiteContentType(
    GUID = "279286fb-05c0-4f7f-9211-786484986a7a",
    GroupName = Globals.GroupNames.Specialized)]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class MallPage : SitePageData
    {

        [Display(
            GroupName = SystemTabNames.Content
        )]
        public virtual ContentArea MainContentArea { get; set; }
    }
}
