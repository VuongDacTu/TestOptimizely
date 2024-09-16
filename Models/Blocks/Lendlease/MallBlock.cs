using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks.Lendlease
{
    [ContentType(DisplayName = "MallBlock", GUID = "f510f580-b1dc-4ea1-94a2-29a7203b68f5", Description = "")]
    public class MallBlock : SiteBlockData
    {
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
        [CultureSpecific]
        public virtual string Content { get; set; }
        [CultureSpecific]
        public virtual string Place { get; set; }
        [CultureSpecific]
        public virtual string Datetime { get; set; }
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }
        [CultureSpecific]

        public virtual Url Url { get; set; }
    }
   
}
