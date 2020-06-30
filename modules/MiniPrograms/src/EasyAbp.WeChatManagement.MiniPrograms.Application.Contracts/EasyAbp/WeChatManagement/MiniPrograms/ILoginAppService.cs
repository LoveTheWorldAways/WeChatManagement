﻿using System.Threading.Tasks;
using EasyAbp.WeChatManagement.MiniPrograms.Dtos;
using IdentityModel.Client;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.WeChatManagement.MiniPrograms
{
    public interface ILoginAppService : IApplicationService
    {
        Task<TokenResponse> LoginAsync(LoginDto input);
        
        Task<TokenResponse> RefreshAsync(RefreshDto input);

        Task<ListResultDto<BasicTenantInfo>> GetTenantsAsync(string appId, string code);
    }
}