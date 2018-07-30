namespace WeddingAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Guest")]
    public partial class GuestEntry
    {
        [Key]
        [StringLength(6)]
        public string CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        public int? NUM_ADULTS { get; set; }

        public int? NUM_KIDS { get; set; }

        public string MESSAGE { get; set; }

        public DateTime? TIMESTAMP { get; set; }

        public bool? REG_FLAG { get; set; }
    }
}
