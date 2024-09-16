using Blend.Cms12.Models.Blocks.DownloadApp;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks.Start
{
    [SiteContentType(GUID = "3E7C8E66-6DCE-4E90-A0B5-0920FCB1E25D")]

    public class Section2Block: SiteBlockData
    {
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
        public virtual ContentArea Button { get; set; }
    }
}
