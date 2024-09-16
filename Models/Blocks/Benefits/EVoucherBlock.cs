namespace Blend.Cms12.Models.Blocks.Benefits
{
	[ContentType(DisplayName = "Evoucher Block", GUID = "010c0e8c-fdf4-4289-ad02-09d3d2f6d42b", Description = "Gift voucher Block")]

	public class EVoucherBlock : SiteBlockData
	{
		public virtual string Content { get; set; }
		public virtual XhtmlString Description { get; set; }
		public virtual ContentArea Voucher { get; set; }
	}
}
