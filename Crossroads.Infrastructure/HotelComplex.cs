namespace Crossroads.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelComplex")]
    public partial class HotelComplexEntity
    {
        public long ID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Address { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        public long EmployeeAmount { get; set; }

        [StringLength(2147483647)]
        public string Services { get; set; }

        public long RoomsAmount { get; set; }

        public long ClientsAmount { get; set; }

        public long BookingsAmount { get; set; }
    }
}
