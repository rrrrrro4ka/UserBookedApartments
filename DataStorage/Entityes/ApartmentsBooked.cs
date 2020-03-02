using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStorage.Entityes
{
    public class ApartmentsBooked
    {
        private int apartmentId;
        private int userId;
        private DateTime dateStartBooked;
        private DateTime dateEndBooked;
        private int id;
        [Required]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required]
        public int ApartmentId
        {
            get { return apartmentId; }
            set { apartmentId = value; }
        }
        [Required]
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public DateTime DateStartBooked
        {
            get { return dateStartBooked; }
            set
            {
                if (!String.IsNullOrEmpty(value.ToString()))
                {
                    dateStartBooked = value;
                }
            }
        }
        public DateTime DateEndBooked
        {
            get { return dateEndBooked; }
            set
            {
                if (!String.IsNullOrEmpty(value.ToString()))
                {
                    dateEndBooked = value;
                }
            }
        }
        public int CountGuest { get; set; }
    }
}
