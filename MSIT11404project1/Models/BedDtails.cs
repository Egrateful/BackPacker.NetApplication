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
    
    public partial class BedDtails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BedDtails()
        {
            this.Booking = new HashSet<Booking>();
        }
    
        public Nullable<int> BedTypeID { get; set; }
        public Nullable<int> BedCount { get; set; }
        public int BedInSpaceID { get; set; }
        public Nullable<int> HouseKey { get; set; }
        public string SpaceIntro { get; set; }
        public Nullable<decimal> RoomPrice { get; set; }
        public Nullable<bool> Ispublic { get; set; }
    
        public virtual BedType BedType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual HouseMain HouseMain { get; set; }
    }
}