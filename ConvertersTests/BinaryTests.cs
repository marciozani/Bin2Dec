using Converters;

namespace ConvertersTests
{
  public class BinaryTests
  {
    [Theory]
    [InlineData("0", 0)]
    [InlineData("1", 1)]
    [InlineData("100101", 37)]
    [InlineData("01111111111111111111111111111111", 2147483647)]
    public void ValidBinaryInput_ShouldReturnIsIntValue(string input, int expected) =>
      Assert.Equal(expected, Binary.StringToInt(input));

    [Theory]
    [InlineData("A")]
    [InlineData(null)]
    [InlineData("2")]
    [InlineData("11111111111111111111111111111111")]
    [InlineData("001111111111111111111111111111111")]
    public void InvalidBinaryInput_ShouldThrowArgumentException(string input) =>
      Assert.Throws<ArgumentException>(() => Binary.StringToInt(input));
  }
}