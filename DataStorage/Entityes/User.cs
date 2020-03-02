using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStorage.Entityes
{
    public class User
    {
        private int id;
        private string login;
        private string mobilePhone;

        [Required]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }
        public List<ApartmentsBooked> ApartmentsBooked { get; set; }
    }
}
