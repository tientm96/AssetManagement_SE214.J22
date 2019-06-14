﻿using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.BidProfile.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Contract.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.Contract
{
   public interface IContractAppService
    {
        Task<PagedResultDto<ContractDto>> GetContractsAsync(GetMenuClientInput input);
        Task<ContractDto> GetContractByIdAsync(EntityDto<int> input);
        Task<ContractDto> CreateContractAsync( ContractSavedDto contractSaved);
        Task<ContractDto> updateContractAsync(ContractSavedDto contractSaved);
        Task DeleteContractAsync(EntityDto<int> input);
        Task<PagedResultDto<BidProfileDto>> GetApprovedBidProfile();
        Task<ContractDto> ApproveContract(EntityDto<int> input);
        Task<ContractDto> CloseContract(EntityDto<int> input);
    }
}
