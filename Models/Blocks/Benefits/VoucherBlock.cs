using EPiServer.Shell.ObjectEditing;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks.Benefits
{
	[ContentType(DisplayName = "Card Voucher", GUID = "619161e7-8794-4285-b648-a2e11f695eed", Description = "This is voucher item in Gift Voucher Page")]

	public class VoucherBlock : SiteBlockData
	{
		public virtual int Money {  get; set; }
		public virtual int Plus { get; set; }
		[Display(Name = "Color card voucher", Description = "Color card voucher", Order = 10)]
		[SelectOne(SelectionFactoryType = typeof(Color))]
		public virtual string Color {  get; set; }
	}
	public class Color : ISelectionFactory
	{
		public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
		{
			return new List<SelectItem>
				{
					new SelectItem { Text = "Orange", Value = "orange" },
					new SelectItem { Text = "Blue", Value = "blue" },
					new SelectItem { Text = "Green", Value = "green" },
				};
		}
	}
}
