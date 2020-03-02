using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStorage.Entityes
{
    public class Apartments
    {
        [Required]
        public int Id { get; set; }
        public string Address { get; set; }
        public double Area { get; set; }
        public int Rooms { get; set; }
        public int MaxGuets { get; set; }
        public decimal Cost { get; set; }
        public List<ApartmentsBooked> ApartmentsBooked { get; set; }
    }
}
