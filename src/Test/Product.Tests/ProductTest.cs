using System;
using Xunit;

namespace Product.Tests;

public class ProductTest
{
    [Fact]
    public void ProductIsCreated()
    {
        var product = new Business.Product("pasta", "12345667888", DateTime.UtcNow);

        Assert.NotNull(product.Name);
        Assert.NotNull(product.Ean);
    }

    [Fact]
    public void ProductNameIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => new Business.Product(null!, "12345667888", DateTime.UtcNow));
    }

    [Fact]
    public void ProductEanIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => new Business.Product("pasta", null!, DateTime.UtcNow));
    }

    [Fact]
    public void ProductNameIsEmpty()
    {
        Assert.Throws<ArgumentNullException>(() => new Business.Product("", "12345667888", DateTime.UtcNow));
    }

    [Fact]
    public void ProductEanIsEmpty()
    {
        Assert.Throws<ArgumentNullException>(() => new Business.Product("pasta", "", DateTime.UtcNow));
    }
}
