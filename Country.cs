namespace EFExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int NamesId { get; set; }

        [Column("Country")]
        [Required]
        [StringLength(50)]
        public string Country1 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        public int Home { get; set; }

        public int Apartment { get; set; }

        public virtual Name Name { get; set; }
    }
}
