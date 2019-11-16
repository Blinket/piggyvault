﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Piggyvault.Piggy.Reports.Dto;
using System.Threading.Tasks;

namespace Piggyvault.Piggy.Reports
{
    public interface IReportAppService : IApplicationService
    {
        Task<ListResultDto<CategoryReportOutputDto>> GetCategoryReport(GetCategoryReportInput input);

        Task<ListResultDto<GetCategoryWiseTransactionSummaryHistoryOuputDto>>
            GetCategoryWiseTransactionSummaryHistory(GetCategoryWiseTransactionSummaryHistoryInputDto input);
    }
}