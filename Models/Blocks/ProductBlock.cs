using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks
{

    [SiteContentType(GUID = "c7a8df2e-e17c-4531-8594-fc6fb689bac4")]
    [SiteImageUrl]
    public class ProductBlock : SiteBlockData
    {
        [UIHint(UIHint.Image)]

        public virtual ContentReference Image { get; set; }
        [UIHint(UIHint.Image)]

        public virtual ContentReference Banner { get; set; }
        public virtual string Name { get; set; }
        public virtual string Location { get; set; }
        public virtual DateTime OpenTime { get; set; }
        public virtual DateTime CloseTime { get; set; }
        public virtual XhtmlString Description { get; set; }
        public virtual Url UrlDetail { get; set; }
    }
}
