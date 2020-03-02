using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStorage
{
    public static class SampleDataAdd
    {
        public static void InitData(FrameworkDBContext context)
        {
            if(!context.Apartments.Any())
            {
                context.Add(new Entityes.Apartments()
                {
                    Address = "Krasniy prospekt",
                    Area = 10.2,
                    Cost = 14000,
                    Rooms = 1,
                    MaxGuets = 2
                });
                context.Add(new Entityes.Apartments()
                {
                    Address = "MKAD",
                    Area = 34.2,
                    Cost = 18000,
                    Rooms = 1,
                    MaxGuets = 3
                });
                context.Add(new Entityes.Apartments()
                {
                    Address = "Lenevo",
                    Area = 37,
                    Cost = 12000,
                    Rooms = 1,
                    MaxGuets = 1
                });
                context.SaveChanges();
                context.Add(new Entityes.User()
                {
                    Login = "pasternak",
                    MobilePhone = "+79135550450"
                });
                context.Add(new Entityes.User()
                {
                    Login = "Oskar",
                    MobilePhone = "+79136660450"
                });
                context.SaveChanges();
            }
        }
    }
}
