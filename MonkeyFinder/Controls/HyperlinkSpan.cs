using System.Windows.Input;

namespace MonkeyFinder.Controls;

/// <summary>
/// A span that displays a hyperlink
/// </summary>
public class HyperlinkSpan : Span
{
  /// <summary>
  /// The Command to call when the hyperlink is tapped
  /// </summary>
  public ICommand TapCommand
  {
    get { return (ICommand)GetValue(TapCommandProperty); }
    set { SetValue(TapCommandProperty, value); }
  }

  public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(nameof(TapCommand), typeof(ICommand), typeof(HyperlinkSpan), propertyChanged: OnTapCommandChanged);

  private static void OnTapCommandChanged(BindableObject bindable, object oldValue, object newValue)
  {
    var control = bindable as HyperlinkSpan;
    control._tapGestureRecognizer.Command = newValue as ICommand;
  }

  /// <summary>
  /// The Tap Command parameter
  /// </summary>
  public object TapCommandParameter
  {
    get { return GetValue(TapCommandParameterProperty); }
    set { SetValue(TapCommandParameterProperty, value); }
  }

  public static readonly BindableProperty TapCommandParameterProperty = BindableProperty.Create(nameof(TapCommandParameter), typeof(object), typeof(HyperlinkSpan), propertyChanged: OnTapCommandParameterChanged);

  private static void OnTapCommandParameterChanged(BindableObject bindable, object oldValue, object newValue)
  {
    var control = bindable as HyperlinkSpan;
    control._tapGestureRecognizer.CommandParameter = newValue;
  }

  private readonly TapGestureRecognizer _tapGestureRecognizer;

  public HyperlinkSpan()
  {
    _tapGestureRecognizer = new TapGestureRecognizer();
    GestureRecognizers.Add(_tapGestureRecognizer);
  }
}
