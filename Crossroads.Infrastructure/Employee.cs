namespace Crossroads.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class EmployeeEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeEntity()
        {
            User = new HashSet<UserEntity>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string LastName { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string MiddleName { get; set; }

        public long Position { get; set; }

        public virtual PositionEntity Position1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserEntity> User { get; set; }
    }
}
