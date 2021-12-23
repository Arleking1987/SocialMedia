using System;
using System.Collections.Generic;
using System.Text;
using App.Common.DTOs;
using App.Infrastructure.Entities;
using AutoMapper;

namespace App.Config
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<SpecialMeasureEntity, SpecialMeasureContract>().ReverseMap();
            
        }
    }
}
