using Converters;

namespace ConvertersTests
{
  public class BinaryTests
  {
    [Fact]
    public void Test1()
    {
      string bin = "100101";
      int result = Binary.StringToInt(bin);
      Assert.Equal(37, result);
    }
  }
}