namespace MauiTodoApp.Views.Contents;

public partial class BottomBar : ContentView
{
    public static readonly BindableProperty BottomBarPageProperty = BindableProperty.Create(nameof(BottomBarPage), typeof(List<ContentView>), typeof(BottomBar));
    public List<ContentView> BottomBarPage
    {
        get => (List<ContentView>)GetValue(BottomBarPageProperty);
        set => SetValue(BottomBarPageProperty, value);
    }

    public static readonly BindableProperty MainPageGridProperty = BindableProperty.Create(nameof(MainPageGrid), typeof(Grid), typeof(BottomBar));

    public Grid MainPageGrid
    {
        get => (Grid)GetValue(MainPageGridProperty);
        set => SetValue(MainPageGridProperty, value);
    }

    public static readonly BindableProperty CounterProperty = BindableProperty.Create(nameof(MainCounter), typeof(string), typeof(BottomBar), "null");
    public string MainCounter
    {
        get => (string)GetValue(CounterProperty);
        set => SetValue(CounterProperty, value);
    }

    List<ContentView> pages = new List<ContentView> { new Pages.FirstPage(), new Pages.SecondPage() };

    public BottomBar()
    {
        InitializeComponent();
        ButtonBackgroundColorSelect(CurrentPageIndex);

    }

    Color highlightColor = Colors.LightPink;
    Color normalColor = Colors.Transparent;

    private void ButtonBackgroundColorSelect(int index)
    {
        switch (index)
        {
            case 0:
                button1.BackgroundColor = highlightColor;
                button2.BackgroundColor = normalColor;
                button3.BackgroundColor = normalColor;
                button4.BackgroundColor = normalColor;
                break;
            case 1:
                button1.BackgroundColor = normalColor;
                button2.BackgroundColor = highlightColor;
                button3.BackgroundColor = normalColor;
                button4.BackgroundColor = normalColor;
                break;
            case 2:
                button1.BackgroundColor = normalColor;
                button2.BackgroundColor = normalColor;
                button3.BackgroundColor = highlightColor;
                button4.BackgroundColor = normalColor;
                break;
            case 3:
                button1.BackgroundColor = normalColor;
                button2.BackgroundColor = normalColor;
                button3.BackgroundColor = normalColor;
                button4.BackgroundColor = highlightColor;
                break;
        }
    }

    int CurrentPageIndex = 0;
    private void Page1Clicked(object sender, TappedEventArgs e)
    {
        MainPageGrid.Children.Remove(BottomBarPage[CurrentPageIndex]);
        MainPageGrid.Children.Add(BottomBarPage[0]);
        CurrentPageIndex = 0;
        ButtonBackgroundColorSelect(CurrentPageIndex);

    }

    private void Page2Clicked(object sender, TappedEventArgs e)
    {
        MainPageGrid.Children.Remove(BottomBarPage[CurrentPageIndex]);
        MainPageGrid.Children.Add(BottomBarPage[1]);
        CurrentPageIndex = 1;
        ButtonBackgroundColorSelect(CurrentPageIndex);
    }

    private void Page3Clicked(object sender, TappedEventArgs e)
    {
        MainPageGrid.Children.Remove(BottomBarPage[CurrentPageIndex]);
        MainPageGrid.Children.Add(BottomBarPage[2]);
        CurrentPageIndex = 2;
        ButtonBackgroundColorSelect(CurrentPageIndex);
    }

    private void Page4Clicked(object sender, TappedEventArgs e)
    {
        MainPageGrid.Children.Remove(BottomBarPage[CurrentPageIndex]);
        MainPageGrid.Children.Add(BottomBarPage[3]);
        CurrentPageIndex = 3;
        ButtonBackgroundColorSelect(CurrentPageIndex);
    }
}