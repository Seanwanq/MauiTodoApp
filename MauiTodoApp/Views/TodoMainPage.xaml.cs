namespace MauiTodoApp.Views;

public partial class TodoMainPage : ContentPage
{
    List<ContentView> pages = new List<ContentView> { new Pages.FirstPage(), new Pages.SecondPage(),
        new Pages.ThirdPage(), new Pages.FourthPage() };


    public TodoMainPage()
    {
        InitializeComponent();
        MainPageView.Children.Add(pages[0]);
        bottomBar.MainPageGrid = MainPageView;
        bottomBar.BottomBarPage = pages;


    }
}