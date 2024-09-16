namespace Blend.Cms12.Models.Blocks.Benefits
{
	[ContentType(DisplayName = "Membership Block", GUID = "44af993d-02c1-4f52-b92d-31a0b57448a1", Description = "Membership Block")]
	public class MembershipBlock : SiteBlockData 
	{
		public virtual string Content { get; set; }
		public virtual string Title { get; set; }
		public virtual string Description1 { get; set; }
		public virtual string Description2 { get; set;}
		public virtual string Description3 { get; set;}
	}
}
