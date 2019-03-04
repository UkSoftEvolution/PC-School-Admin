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
        private Notify notify; //Трей
        private StateWindow stateWindow; //Состояние окна
        #endregion

        /// <summary>
        /// Конструктор главной модели представлений
        /// </summary>
        public MainViewModel()
        {
            active = new ActivePage();
            if (Properties.Settings.Default.First_Start)
            {
                Active = new RegView() { DataContext = new RegViewModel(active) };
                stateWindow = new StateWindow(true);
            }
            else
            {
                Active = new AuthView() { DataContext = new AuthViewModel() };
                stateWindow = new StateWindow(false);
            }
            notify = new Notify(stateWindow);
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
        /// <summary>
        /// Состояние окна
        /// </summary>
        public StateWindow StateWindow { get => stateWindow; }
        #endregion
    }
}