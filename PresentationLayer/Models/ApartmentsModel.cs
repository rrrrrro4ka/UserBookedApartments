using DataStorage.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PresentationLayer.Models
{
    public class ApartmentsViewModel : PageViewModel
    {
        public Apartments Apartments { get; set; }
    }
    public class ApartmentsEditModel : PageEditModel
    {
        [Required]
        public string Address { get; set; }
        public double Area { get; set; }
        public int Rooms { get; set; }
        public int MaxGuets { get; set; }
        public decimal Cost { get; set; }
    }
}
