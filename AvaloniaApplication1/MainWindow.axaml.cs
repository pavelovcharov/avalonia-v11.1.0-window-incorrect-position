using Avalonia.Controls;

namespace AvaloniaApplication1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PositionChanged += (s, e) => textBlock.Text = $"Actual Positon: {Position}";
        }
    }
}