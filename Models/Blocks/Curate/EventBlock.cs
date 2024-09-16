using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks.Curate
{
	[ContentType(DisplayName = "Curate+ Event", GUID = "FED870E0-A97D-4530-BAF2-45AD4B382B08", Description = "Curate+ Event")]

	public class EventBlock : SiteBlockData
	{
		[UIHint(UIHint.Image)]
		public virtual ContentReference Image { get; set; }
		public virtual string Title { get; set; }	
		public virtual string Location {  get; set; }
		public virtual DateTime Date1 {  get; set; }
		public virtual DateTime Date2 { get; set; }
		public virtual XhtmlString Description { get; set; }
		public virtual Url Url { get; set; }
	}
}
