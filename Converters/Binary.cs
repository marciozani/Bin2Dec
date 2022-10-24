namespace Converters;

public static class Binary
{
  // Max representation of a int in binary is 01111111111111111111111111111111
  // So, we just accept 31 characters and the first one must be zero
  private const int _maxLength = 32;

  public static bool IsValid(string value)
  {
    return value is not null &&
      value.Length <= _maxLength &&
      (value.Length != _maxLength || value[0] == '0') &&
      value.All(c => IsBinaryChar(c));
  }

  private static bool IsBinaryChar(char c) => c == '0' || c == '1';

  public static int StringToInt(string value)
  {
    if (!IsValid(value))
      throw new ArgumentException(value, nameof(value));

    int i = 0;
    return value
      .Reverse()
      .Aggregate(0, (acc, current) =>
        acc + ((int)char.GetNumericValue(current) * (int)Math.Pow(2, i++)));
  }
}