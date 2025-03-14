﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using AssignmentEf04.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentEf04.Context
{
    public partial interface INORTHWNDContextProcedures
    {
        Task<List<GetEmployeesByDateRangeResult>> GetEmployeesByDateRangeAsync(DateOnly? beginDate, DateOnly? endDate, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<Sp_GetCustomerOrderHistoryResult>> Sp_GetCustomerOrderHistoryAsync(string customerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_UpdateProductPricesResult>> SP_UpdateProductPricesAsync(int? categoryID, decimal? percentage, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
