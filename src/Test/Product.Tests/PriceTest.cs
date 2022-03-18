using System;
using Xunit;

namespace Product.Tests;

public class PriceTest
{
    [Fact]
    public void PriceIsCreated()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var price = new Business.Price(1.50, startDate, endDate);

        Assert.Equal(1.50, price.ActualPrice);
        Assert.Equal(startDate, price.StartDate);
        Assert.Equal(endDate, price.EndDate);
    }

    [Fact]
    public void PriceIsNull()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);

        Assert.Throws<ArgumentNullException>(() => new Business.Price(null, startDate, endDate));
    }

    [Fact]
    public void PriceIsInValid()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var price = -1.50;

        Assert.Throws<Exception>(() => new Business.Price(price, startDate, endDate));
    }

    [Fact]
    public void StartDateIsNull()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var price = 1.50;

        Assert.Throws<ArgumentNullException>(() => new Business.Price(price, null, endDate));
    }

    [Fact]
    public void EndDateIsNull()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var price = 1.50;

        Assert.Throws<ArgumentNullException>(() => new Business.Price(price, startDate, null));
    }

    [Fact]
    public void AllDateIsNull()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var price = 1.50;

        Assert.Throws<ArgumentNullException>(() => new Business.Price(price, null, null));
    }
}