//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSIT11404project1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Places
    {
        public int PlaceID { get; set; }
        public string Address { get; set; }
        public string ArrivalWay { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string ImageWebSite { get; set; }
        public string Name { get; set; }
        public string Notice { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public int CityID { get; set; }
    
        public virtual Cities Cities { get; set; }
    }
}
