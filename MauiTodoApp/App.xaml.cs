namespace MauiTodoApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Views.TodoMainPage();
    }
}
