using BusinessService.Interfaces;
using DataStorage;
using DataStorage.Entityes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Добавить асинхронно нового пользователя
        /// </summary>
        /// <param name="aps"></param>
        /// <returns></returns>
        public async Task AddApartmentAsync(Apartments aps)
        {
            var apartmentAdd = await context.Apartments.FindAsync(aps.Id);
            if (apartmentAdd == null)
            {
                context.Add(aps);
                await context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Удалить апартамент
        /// </summary>
        /// <param name="apsId"></param>
        /// <returns></returns>
        public async Task DeleleteApartmentAsync(int apsId)
        {
            var apartment = await context.Apartments.FindAsync(apsId);
            if (apartment != null)
            {
                context.Apartments.Remove(apartment);
                await context.SaveChangesAsync();
            }
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
        /// Получаем асинхронно все апартаменты
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<Apartments>>> GetAllApartmentsAsync()
        {
            return await context.Apartments.ToListAsync();
        }

        /// <summary>
        /// Получить асинхронно информацию по конкретному апартменту
        /// </summary>
        /// <param name="apsId"></param>
        /// <returns></returns>
        public async Task<ActionResult<Apartments>> GetApartmentAsync(int apsId)
        {
            return await context.Apartments.FindAsync(apsId);
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
