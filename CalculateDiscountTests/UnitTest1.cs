using Discount_Overload;

namespace CalculateDiscountTests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateDiscountAmount_WithDiscountRate_ReturnsCorrectValue()
        {
            var calc = new CalculateDiscount();
            var result = calc.CalculateDiscountAmount(4000, 0.1);
            Assert.Equal(400, result);
        }

        [Fact]
        public void CalculateDiscountAmount_WithDiscountAmount_ReturnsCorrectValue() 
        {
            var calc = new CalculateDiscount();
            var result = calc.CalculateDiscountAmount(4000, 1000m);
            Assert.Equal(3000, result);
        }
    }
}
