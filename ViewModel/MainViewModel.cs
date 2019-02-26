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
        ActivePage active; //Активная страница
        #endregion

        /// <summary>
        /// Конструктор главной модели представлений
        /// </summary>
        public MainViewModel()
        {
            active = new ActivePage();

            Active = new RegView() { DataContext = new RegViewModel(active) };
        }

        #region Methods
        /// <summary>
        /// Активная страница
        /// </summary>
        public Page Active
        {
            get => active.Active;
            set => active.Active = value;
        }
        #endregion
    }
}