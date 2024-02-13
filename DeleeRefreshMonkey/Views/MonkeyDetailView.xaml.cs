using DeleeRefreshMonkey.ViewModels;
namespace DeleeRefreshMonkey.Views;

public partial class MonkeyDetailView : ContentPage
{
    public MonkeyDetailView(MonkeyDetailViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }
}