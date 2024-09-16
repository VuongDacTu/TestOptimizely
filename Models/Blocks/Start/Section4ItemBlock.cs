using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks.Start
{
    [SiteContentType(GUID = "413B6DE4-D034-47F5-997F-A88B12832FE8")]

    public class Section4ItemBlock : SiteBlockData
    {
        public virtual string Content {  get; set; }
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
        public virtual Url Url { get; set; }
    }
}
