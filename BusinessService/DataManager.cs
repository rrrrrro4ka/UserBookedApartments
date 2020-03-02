using BusinessService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService
{
    public class DataManager
    {
        private IApartments apartments;
        private IUsers users;
        public DataManager(IApartments apartments, IUsers users)
        {
            this.apartments = apartments;
            this.users = users;
        }

        public IApartments Apartments { get { return apartments; } }
        public IUsers Users { get { return users; } }
    }
}
