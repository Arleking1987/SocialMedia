using App.Common.Clases.Base.Repositories;
using App.Infrastructure.Data;
using App.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
    public class SpecialMeasureRepository :  ISpecialMeasureRepository
    {
        private readonly Estado_PedidosContext _context;

        public SpecialMeasureRepository(Estado_PedidosContext context)
        {
            _context = context;
        }

        public async Task CreateMessage(SpecialMeasureEntity message)
        {
            _context.SpecialMeasures.Add(message);
            await _context.SaveChangesAsync();
        }

        public List<SpecialMeasureEntity> GetAllMessages()
        {
            return _context.SpecialMeasures.ToList();
        }
    }
}
