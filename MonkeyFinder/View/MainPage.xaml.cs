using MonkeyFinder.Controls;

namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
  public MainPage(MonkeysViewModel viewModel)
  {
    InitializeComponent();
    BindingContext = viewModel;
  }


  //public static readonly BindableProperty ShowProperty = BindableProperty.Create(nameof(Show), typeof(bool), typeof(MainPage), defaultValue: true);

  //public bool Show
  //{
  //  get => (bool)GetValue(ShowProperty);
  //  set => SetValue(ShowProperty, value);
  //}

  private void Button_Clicked(object sender, EventArgs e)
  {
    SetSpan();
  }

  private void SetSpan()
  {
    var span1 = new HyperlinkSpan
    {
      Text = "Tap Gesture Span 1",
      TapCommand = new RelayCommand(async () =>
      {
        await Application.Current.MainPage.DisplayAlert("Title", "FIRST", "cancel");
      })
    };

    var formattedString = new FormattedString();
    formattedString.Spans.Add(span1);

    var slash = new Span
    {
      Text = " / "
    };

    formattedString.Spans.Add(slash);

    var span2 = new HyperlinkSpan
    {
      Text = "Tap Gesture Span 2",
      TapCommand = new RelayCommand(async () =>
      {
        await Application.Current.MainPage.DisplayAlert("Title", "SECOND", "cancel");
      })
    };

    formattedString.Spans.Add(span2);

    theLabel.FormattedText = formattedString;
  }
}



