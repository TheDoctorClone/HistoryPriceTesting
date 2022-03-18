using System;
using Xunit;

namespace Product.Tests;

public class DiscountTest
{
    [Fact]
    public void DiscountIsCreated()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var actualDiscount = 10;

        var discount = new Business.Discount(actualDiscount, startDate, endDate);

        Assert.Equal(10, discount.ActualDiscount);
        Assert.Equal(startDate, discount.StartDate);
        Assert.Equal(endDate, discount.EndDate);
    }

    [Fact]
    public void DiscountIsNull()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var actualDiscount = 10;

        Assert.Throws<ArgumentNullException>(() => new Business.Discount(null, startDate, endDate));
    }

    [Fact]
    public void StartDateIsNull()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var actualDiscount = 10;

        Assert.Throws<ArgumentNullException>(() => new Business.Discount(actualDiscount, null, endDate));
    }

    [Fact]
    public void EndDateIsNull()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var actualDiscount = 10;

        Assert.Throws<ArgumentNullException>(() => new Business.Discount(actualDiscount, startDate, null));
    }

    [Fact]
    public void DiscountValueIsValid()
    {
        var startDate = DateTime.UtcNow;
        var endDate = DateTime.UtcNow.AddDays(10);
        var actualDiscount1 = 13;
        var actualDiscount2 = 0;
        var actualDiscount3 = -13;

        Assert.Throws<ArgumentOutOfRangeException>(() => new Business.Discount(actualDiscount1, startDate, endDate));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Business.Discount(actualDiscount2, startDate, endDate));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Business.Discount(actualDiscount3, startDate, endDate));
    }
}
