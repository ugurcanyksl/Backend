using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Car
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(70)]
        public string Brand { get; set; }
        [StringLength(70)]
        public string Model { get; set; }
        [StringLength(10)]
        public string Plaque { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
