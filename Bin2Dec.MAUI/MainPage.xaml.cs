namespace Bin2Dec.MAUI
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
      if (!Converters.Binary.IsValid(e.NewTextValue))
      {
        BinaryEntry.Text = e.OldTextValue;
        return;
      }

      DecimalEntry.Text = Converters.Binary.StringToInt(BinaryEntry.Text).ToString();
    }
  }
}