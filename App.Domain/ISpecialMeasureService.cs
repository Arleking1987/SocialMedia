using App.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
   public interface ISpecialMeasureService
    {
        public List<SpecialMeasureContract> GetAllMessages();
        public Task CreateMessage(SpecialMeasureContract message);
    }
}
