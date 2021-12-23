using App.Common.DTOs;
using App.Infrastructure.Entities;
using App.Infrastructure.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    
   public class SpecialMeasureService : ISpecialMeasureService
    {
        private readonly ISpecialMeasureRepository _specialMeasureRepository;
        private readonly IMapper _mapper;

        public SpecialMeasureService(ISpecialMeasureRepository specialMeasureRepository, IMapper mapper)
        {
            _specialMeasureRepository = specialMeasureRepository;
            _mapper = mapper;
        }

        public async Task CreateMessage(SpecialMeasureContract message)
        {
            message.MessageTime = DateTime.Now;
            message.Status = "0";
            await _specialMeasureRepository.CreateMessage( _mapper.Map<SpecialMeasureEntity>(message));           
        }

        public List<SpecialMeasureContract> GetAllMessages()
        {
            List<SpecialMeasureEntity> listMessagesEntities= _specialMeasureRepository.GetAllMessages();
            return _mapper.Map<List<SpecialMeasureContract>>(listMessagesEntities);

        }
    }
}
