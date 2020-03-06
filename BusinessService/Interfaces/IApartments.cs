using DataStorage.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Interfaces
{
    public interface IApartments
    {
        IEnumerable<Apartments> GetAllApartments();
        Apartments GetApartmentsbyId(int apartmentId);
        void SaveApartment(Apartments aps);
        void DeleteApartment(int apsId);
    }
}
