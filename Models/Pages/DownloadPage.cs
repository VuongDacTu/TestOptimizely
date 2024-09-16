using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Pages
{
    [SiteContentType(GUID = "7d7cb5b8-bf8d-41bc-903c-1ea539db538b")]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-standard.png")]
    public class DownloadPage : SitePageData
    {
        [CultureSpecific]
        public virtual string Content { get; set; }
        [CultureSpecific]
        public virtual string Description { get; set; }
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
        public virtual ContentArea ContentArea { get; set; }
    }
}
