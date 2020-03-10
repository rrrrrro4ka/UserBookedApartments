using DataStorage.Entityes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Interfaces
{
    public interface IApartments
    {
        IEnumerable<Apartments> GetAllApartments();
        Task<ActionResult<IEnumerable<Apartments>>> GetAllApartmentsAsync();
        Apartments GetApartmentsbyId(int apartmentId);
        Task<ActionResult<Apartments>> GetApartmentAsync(int apsId);
        void SaveApartment(Apartments aps);
        Task AddApartmentAsync(Apartments aps);
        void DeleteApartment(int apsId);
        Task DeleleteApartmentAsync(int apsId);
    }
}
