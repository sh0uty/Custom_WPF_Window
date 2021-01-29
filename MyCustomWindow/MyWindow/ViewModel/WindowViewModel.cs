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

        #endregion

        #region Public Member


        #endregion

        #region Command

        public ICommand PlaceHolder { get; private set; }

        #endregion
    }
}
