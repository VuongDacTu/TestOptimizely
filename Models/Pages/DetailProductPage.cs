using Blend.Cms12.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Pages
{
    [SiteContentType(
        GUID = "BC5C9E65-77A6-4D2E-9042-A5FD0EA7AEFF",
        GroupName = Globals.GroupNames.Default)]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class DetailProductPage : SitePageData 
    {
        [Display(Name = "Content Area", Order = 10)]
        public virtual ContentArea ContentArea { get; set; }
    }
}
