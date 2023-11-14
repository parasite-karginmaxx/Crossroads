namespace Crossroads.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class RoomEntity
    {
        public long ID { get; set; }

        public long RoomType { get; set; }

        public long Booking { get; set; }

        public virtual BookingEntity Booking1 { get; set; }

        public virtual RoomTypeEntity RoomType1 { get; set; }
    }
}
