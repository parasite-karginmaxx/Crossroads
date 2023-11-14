namespace Crossroads.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class BookingEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookingEntity()
        {
            Client = new HashSet<ClientEntity>();
            Room = new HashSet<RoomEntity>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ArrivalDate { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DepartureDate { get; set; }

        public long RoomType { get; set; }

        public long ClientsAmount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientEntity> Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomEntity> Room { get; set; }
    }
}
