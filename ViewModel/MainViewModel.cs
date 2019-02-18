using PC_School_Admin.Other;
using System.Windows.Controls;

namespace PC_School_Admin.ViewModel
{
    /// <summary>
    /// ViewModel: Класс для Binding с MainView
    /// </summary>
    public class MainViewModel : MVVM
    {
        #region Fields
        Page active; //Активная страница
        #endregion

        #region Methods
        /// <summary>
        /// Активная страница
        /// </summary>
        public Page Active
        {
            get => active;
            set
            {
                active = value;
                OnPropertyChanged(nameof(active));
            }
        }

        #endregion
    }
}