﻿using HRManagementSystem.Dtos.ProvidedServiceDtos;
using HRManagementSystem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Business.Interfaces
{
    public interface IProvidedServiceService : IService<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto, ProvidedService>
    {

    }
}