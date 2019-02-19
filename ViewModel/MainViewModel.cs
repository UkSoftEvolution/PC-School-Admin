using PC_School_Admin.Other;
using PC_School_Admin.View;
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

        /// <summary>
        /// Конструктор главной модели представлений
        /// </summary>
        public MainViewModel()
        {
            Active = new RegView();
        }

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