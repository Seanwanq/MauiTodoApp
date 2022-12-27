namespace MauiTodoApp.Views.Contents;

public partial class TasksContent : ContentView
{
    public static readonly BindableProperty TaskTitleProperty = BindableProperty.Create(nameof(TaskTitle), typeof(string), typeof(TasksContent), string.Empty);
    public string TaskTitle
    {
        get => (string)GetValue(TasksContent.TaskTitleProperty);
        set => SetValue(TasksContent.TaskTitleProperty, value);
    }

    public TasksContent()
    {
        InitializeComponent();
    }
}