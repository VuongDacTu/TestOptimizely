using System.ComponentModel;

namespace Blend.Cms12.Models.Pages
{

    /// <summary>
    /// Used to present a single product
    /// </summary>
    [SiteContentType(
        GUID = "59174EB7-60C7-4EF3-A94E-80C6D3AE7EEE",
        GroupName = Globals.GroupNames.Default)]
    [SiteImageUrl(Globals.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    //[AvailableContentTypes(
    //    Availability = Availability.Specific,
    //    IncludeOn = [typeof(StartPage)])]
    public class ProductPage : SitePageData/*, IHasRelatedContent*/
    {
 
        public virtual ContentArea ContentArea { get; set; }

        //[Required]
        //[Display(Order = 305)]
        //[UIHint(Globals.SiteUIHints.StringsCollection)]
        //[CultureSpecific]
        //public virtual IList<string> UniqueSellingPoints { get; set; }

        //[Display(
        //    GroupName = SystemTabNames.Content,
        //    Order = 330)]
        //[CultureSpecific]
        //[AllowedTypes([typeof(IContentData)], [typeof(JumbotronBlock)])]
        //public virtual ContentArea RelatedContentArea { get; set; }
    }

}
