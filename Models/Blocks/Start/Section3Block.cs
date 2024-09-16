namespace Blend.Cms12.Models.Blocks.Start
{
    [SiteContentType(GUID = "1FD98C76-05D3-44F9-9697-51E5687C7E02")]

    public class Section3Block : SiteBlockData
    {
        public virtual string Title1 {  get; set; }
        public virtual string Title2 { get; set;}
        public virtual ContentArea ContentArea1 { get; set; }
        public virtual ContentArea ContentArea2{ get; set; }
        public virtual ContentArea Button1 { get; set; }
        public virtual ContentArea Button2 { get; set; }
    }
}
