using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks
{
    [SiteContentType(GUID = "AD9C6E93-09C3-42D4-821F-3BB1B68A265E")]
    [SiteImageUrl]
    public class BannerImageBlock : SiteBlockData
    {
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
        public virtual Url Url { get; set; }
        
    }
}
