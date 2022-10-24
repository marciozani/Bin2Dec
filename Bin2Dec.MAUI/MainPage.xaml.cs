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
      DecimalEntry.Text = Converters.Binary.IsValid(e.NewTextValue) ?
        Converters.Binary.StringToInt(BinaryEntry.Text).ToString() : String.Empty;
    }

    private void VerticalStackLayout_Loaded(object sender, EventArgs e)
    {
      BinaryEntry.Focus();
    }
  }
}