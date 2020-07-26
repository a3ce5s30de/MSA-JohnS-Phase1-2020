using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSIMS.Models
{
    public class Address
    {
        [Key]
        public int studentId { get; set; }
        [Required, MaxLength(100)]
        public int StreetNumber { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Suburb { get; set; }
        public string City { get; set; }
        [Required]
        public int Postcode { get; set; }
        [Required]
        public string Country { get; set; }
        [Timestamp]
        public DateTime timeCreated { get; set; }
    }
}
