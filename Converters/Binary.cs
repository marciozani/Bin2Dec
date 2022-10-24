namespace Converters;

public static class Binary
{
  public static bool IsValid(string? str) => str?.All(c => IsBinaryChar(c)) ?? false;

  private static bool IsBinaryChar(char c) => c == '0' || c == '1';


  public static int StringToInt(string value)
  {
    int i = 0;
    return value
      .Reverse()
      .Aggregate(0, (acc, current) =>
        acc + ((int)char.GetNumericValue(current) * (int)Math.Pow(2, i++)));
  }
}