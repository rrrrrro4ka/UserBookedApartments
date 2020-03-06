using BusinessService.Interfaces;
using DataStorage;
using DataStorage.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Implementations
{
    public class EFApartments : IApartments
    {
        private FrameworkDBContext context;
        public EFApartments(FrameworkDBContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Удаление апартамента
        /// </summary>
        /// <param name="aps"></param>
        public void DeleteApartment(int apsId)
        {
            var apsToDelete = context.Apartments.FirstOrDefault(a => a.Id == apsId);
            if (apsToDelete != null) context.Apartments.Remove(apsToDelete);
            context.SaveChanges();
        }

        /// <summary>
        /// Получение всех апартаментов
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Apartments> GetAllApartments()
        {
            return context.Apartments.ToList();
        }

        /// <summary>
        /// Получение конкреный апартамент по id
        /// </summary>
        /// <param name="apartmentId"></param>
        /// <returns></returns>
        public Apartments GetApartmentsbyId(int apartmentId)
        {
            return context.Apartments.FirstOrDefault(a => a.Id == apartmentId);
        }

        /// <summary>
        /// Сохранение апартамента
        /// </summary>
        /// <param name="aps"></param>
        public void SaveApartment(Apartments aps)
        {
            if (aps.Id == 0)
            {
                context.Apartments.Add(aps);
            }
            else
            {
                context.Entry(aps).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
