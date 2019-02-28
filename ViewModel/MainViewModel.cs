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
            if (Properties.Settings.Default.First_Start)
                Active = new RegView() { DataContext = new RegViewModel(active) };
            else
                Active = new AuthView() { DataContext = new AuthViewModel() };
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