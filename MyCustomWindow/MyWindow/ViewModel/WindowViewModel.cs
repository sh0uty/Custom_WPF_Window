using System.Windows;
using System.Windows.Input;

namespace MyCustomWindow.MyWindow.ViewModel
{
    public class WindowViewModel : BaseViewModel
    {
        #region Constructor

        public WindowViewModel(Window window)
        {
            mWindow = window;

            MinimizeCommand = new RelayCommand((param) => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand((param) => mWindow.WindowState = WindowState.Maximized);
            CloseCommand = new RelayCommand((param) => mWindow.Close());
            MenuCommand = new RelayCommand((param) => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));
        }

        #endregion Constructor

        #region Private Member

        private readonly Window mWindow;

        private readonly int iOuterMargin = 10;

        private int iWindowRadius = 10;

        #endregion Private Member

        #region Public Member

        public double WindowMinWidth { get; set; } = 450;

        public double WindowMinHeight { get; set; } = 800;

        public int ResizeBorder { get; set; } = 6;

        public int WindowRadius { get => iWindowRadius; set => iWindowRadius = value; }

        public int TitleHeight { get; set; } = 40;

        public Thickness ResizeBorderThickness { get => new Thickness(ResizeBorder + iOuterMargin); }

        public Thickness OuterMarginThickness { get => new Thickness(iOuterMargin); }

        public Thickness InnerContent { get => new Thickness(ResizeBorder); }

        public CornerRadius WindowCornerRadius { get => new CornerRadius(WindowRadius); }

        public GridLength TitleHeightGridLength { get => new GridLength(TitleHeight + ResizeBorder); }

        #endregion Public Member

        #region Command

        public ICommand MinimizeCommand { get; private set; }
        public ICommand MaximizeCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }
        public ICommand MenuCommand { get; private set; }

        #endregion Command

        #region Private Helper

        private Point GetMousePosition()
        {
            var Position = Mouse.GetPosition(mWindow);

            return new Point(Position.X + mWindow.Left, Position.Y + mWindow.Top);
        }

        #endregion Private Helper
    }
}