using APM.Utilities;
using APM.SL;
using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace APM.SL.Test
{
    public class DiscountTest
    {
        [Fact]
        public void FindDiscountWithException_WhenNotFound_ShouldReturnNotFound()
        {
            // Arrange
            List<Discount>? discounts = new List<Discount>();
            var discount = new Discount();
            var discountName = "40% off";

            // Act & Assert
            var ex = Assert.Throws<DiscountNotFoundException>(() => discount.FindDiscountWithException(discounts, discountName));
            Assert.Equal("Discount not found", ex.Message);
        }

    }
}
