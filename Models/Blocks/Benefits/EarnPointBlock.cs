namespace Blend.Cms12.Models.Blocks.Benefits
{
	[ContentType(DisplayName = "EarnPoint Block", GUID = "3c201a81-8242-4af5-87ea-2deea3f66c85", Description = "EarnPoint Block")]

	public class EarnPointBlock : SiteBlockData
	{
		public virtual string Content { get; set; }
		public virtual XhtmlString Description {  get; set; }
		public virtual string ButtonBasic { get; set; }
		public virtual string DescriptionBasic {  get; set; }
		public virtual string ButtonPremium {  get; set; }
		public virtual string DescriptionPremium { get; set; }



	}
}
