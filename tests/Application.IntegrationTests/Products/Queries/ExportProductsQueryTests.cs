﻿using System.Threading.Tasks;
using AutoFilterer.Enums;
using CleanArchitecture.Blazor.Application.Features.Products.Queries.Export;
using FluentAssertions;
using NUnit.Framework;

namespace CleanArchitecture.Blazor.Application.IntegrationTests.Products.Queries;
using static Testing;
internal class ExportProductsQueryTests : TestBase
{
    [Test]
    public async Task ShouldNotEmptyExportQuery()
    {
        var query = new ExportProductsQuery() {
            Sort =  "Id",
            SortBy = Sorting.Ascending
        };
        var result = await SendAsync(query);
        result.Should().NotBeNull();
    }

    [Test]
    public async Task ShouldNotEmptyExportQueryWithFilter()
    {
        var query = new ExportProductsQuery() { Keyword="1",
            Sort = "Id",
            SortBy = Sorting.Ascending
        };
        var result = await SendAsync(query);
        result.Should().NotBeNull();
    }
}
