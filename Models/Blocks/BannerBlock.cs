using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks
{
    [SiteContentType(GUID = "E544AEC3-DC26-4059-8A35-5FBB82BADB74")]
    public class BannerBlock : SiteBlockData
    {
        [UIHint(UIHint.Image)]
        public virtual ContentArea Image { get; set; }
    }
}
