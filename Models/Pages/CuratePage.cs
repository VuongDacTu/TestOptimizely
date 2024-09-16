using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Pages
{
    [SiteContentType(
  GUID = "C1B9F809-5DA8-4D50-AA8A-670C33FE4DE0",
  GroupName = Globals.GroupNames.Specialized)]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class CuratePage : SitePageData
    {
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageBanner { get; set; }
        public virtual string Content {  get; set; }
        public virtual XhtmlString Description { get; set; }
        public virtual ContentArea Events { get; set; }
    }
}
