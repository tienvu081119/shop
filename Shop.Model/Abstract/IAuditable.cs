using System;

namespace Shop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
        string MetaKeyWord { set; get; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}
