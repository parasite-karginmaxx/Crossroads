namespace Crossroads.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class ClientEntity
    {
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

        public long PhoneNumber { get; set; }

        [StringLength(2147483647)]
        public string Email { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ArrivalDate { get; set; }

        public long Booking { get; set; }

        public virtual BookingEntity Booking1 { get; set; }
    }
}
