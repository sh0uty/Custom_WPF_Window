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

            PlaceHolder = new RelayCommand(x => { });
        }

        #endregion

        #region Private Member

        private readonly Window mWindow;

        private readonly int iResizeBorder = 6;

        private readonly int iOuterMargin = 10;


        #endregion

        #region Public Member

        public Thickness ResizeBorderThickness { get => new Thickness(iResizeBorder + iOuterMargin); }

        public Thickness OuterMarginThickness { get => new Thickness(iOuterMargin); }

        public Thickness InnerContent { get => new Thickness(iResizeBorder); }

        public int TitleHeight { get; set; } = 40;

        #endregion

        #region Command

        public ICommand PlaceHolder { get; private set; }

        #endregion
    }
}
