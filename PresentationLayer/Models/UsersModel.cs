using DataStorage.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Models
{
    public class UsersViewModel : PageViewModel
    {
        public string Login { get; set; }
        public string MobilePhone { get; set; }
        public User Users { get; set; }
    }
    public class UsersEditModel : PageEditModel
    {
        public string Login { get; set; }
        public string MobilePhone { get; set; }
    }
}
