using App.Common.Clases.Base.Repositories;
using App.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
   public interface ISpecialMeasureRepository 
    {
        public List<SpecialMeasureEntity> GetAllMessages();
        public  Task CreateMessage(SpecialMeasureEntity message);
    }
}
