using MonkeyFinder.Services;
using MonkeyFinder.View;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  public MonkeysViewModel()
  {
    //Items = new ObservableCollection<Item>();
    //for (int i = 0; i < 100; i++)
    //{
    //  Items.Add(new Item
    //  {
    //    Name = $"item {i}",
    //    View = new Label
    //    {
    //      Text = "Content View Label"
    //    }
    //  });
    //}
  }

  //public ObservableCollection<Item> Items { get; set; }


  //[RelayCommand]
  //async Task ShowMessage()
  //{
  //  await Application.Current.MainPage.DisplayAlert("Title", "Test", "cancel");
  //}
}

//public class Item
//{
//  public string Name { get; set; }

//  public IView View { get; set; }
//}