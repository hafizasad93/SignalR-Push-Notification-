//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toaster_Notification_Signar_R.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserRole()
        {
            this.RoleModulePermissions = new HashSet<RoleModulePermission>();
            this.Users = new HashSet<User>();
        }
    
        public long RoleId { get; set; }
        public string RoleName { get; set; }
        public Nullable<int> Rank { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.DateTime AddDate { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<int> ApprovalStatusId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleModulePermission> RoleModulePermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
