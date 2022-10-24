namespace Bin2Dec.MAUI
{
  public static class AttachedBinaryValidationBehavior
  {
    public static readonly BindableProperty AttachBehaviorProperty =
        BindableProperty.CreateAttached("AttachBehavior", typeof(bool), typeof(AttachedBinaryValidationBehavior), false, propertyChanged: OnAttachBehaviorChanged);

    public static bool GetAttachBehavior(BindableObject view)
    {
      return (bool)view.GetValue(AttachBehaviorProperty);
    }

    public static void SetAttachBehavior(BindableObject view, bool value)
    {
      view.SetValue(AttachBehaviorProperty, value);
    }

    private static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
    {
      var entry = view as Entry;
      if (entry == null)
      {
        return;
      }

      bool attachBehavior = (bool)newValue;
      if (attachBehavior)
      {
        entry.TextChanged += OnEntryTextChanged;
      }
      else
      {
        entry.TextChanged -= OnEntryTextChanged;
      }
    }

    private static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
    {
      bool isValid = Converters.Binary.IsValid(args.NewTextValue);
      ((Entry)sender).TextColor = isValid ? Colors.White : Colors.Red;
    }
  }
}