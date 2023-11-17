using Microsoft.AspNetCore.Components;
using Test.App.Client.ViewModels;

namespace Test.App.Client.Views;

public partial class TestView
{
    [Inject]
    public required TestViewModel TestViewModel
    {
        get => ViewModel!;
        set => ViewModel = value;
    }
}