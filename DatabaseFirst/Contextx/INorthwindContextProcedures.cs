﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using DatabaseFirst.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DatabaseFirst.Contextx
{
    public partial interface INorthwindContextProcedures
    {
        Task<List<CustOrderHistResult>> CustOrderHistAsync(string customerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<CustOrdersOrdersResult>> CustOrdersOrdersAsync(string customerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SalesbyYearResult>> SalesbyYearAsync(DateTime? beginning_Date, DateTime? ending_Date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SalesByCategoryResult>> SalesByCategoryAsync(string categoryName, string ordYear, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
