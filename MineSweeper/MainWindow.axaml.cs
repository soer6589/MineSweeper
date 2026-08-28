using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MineSweeper;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        timer.Start();
    }
    
    Stopwatch timer = new Stopwatch();

    // Button actions
    private void PressedEmpty(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        button.Content = "";
    }

    private void PressedBoom(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        button.Content = "BOOM!";
        
        timer.Stop();
        ShowTime.Content = $"Tid: {timer.ElapsedMilliseconds} ms";
    }

    private void PressedOne(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        button.Content = "1";
    }

    private void PressedTwo(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        button.Content = "2";
    }
    

    public void PressedReset(object sender, RoutedEventArgs e)
    {
        timer.Reset();
        timer.Start();
        ShowTime.Content = $"Tid: ";
    }
    
    public void newTimer()
    {
        ShowTime.Content = $"Tid: {timer.ElapsedMilliseconds} ms";
    }

}