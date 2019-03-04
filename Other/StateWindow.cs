using System.Windows;

namespace PC_School_Admin.Other
{
    /// <summary>
    /// Класс для определения состояния окна
    /// </summary>
    public class StateWindow : MVVM
    {
        #region Fields
        private bool showInTaskbar; //Отображение в панели задач
        private WindowState windowState; //Состояние окна
        private Visibility visibility; //Видимость
        #endregion

        #region Constructors
        /// <summary>
        /// Конструктор для инициализации данных
        /// </summary>
        /// <param name="State">Состояние окна</param>
        public StateWindow(bool State)
        {
            Tray(State);
        }
        #endregion

        #region Function
        /// <summary>
        /// Функция для сворачивания программы в трей
        /// </summary>
        /// <param name="isEnable">Указатель</param>
        public void Tray(bool isEnable)
        {
            if (isEnable)
            {
                ShowInTaskbar = true;
                WindowState = WindowState.Normal;
                Visibility = Visibility.Visible;
            }
            else
            {
                ShowInTaskbar = false;
                WindowState = WindowState.Minimized;
                Visibility = Visibility.Collapsed;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Отображение в панели задач
        /// </summary>
        public bool ShowInTaskbar
        {
            get => showInTaskbar;
            set
            {
                showInTaskbar = value;
                OnPropertyChanged(nameof(showInTaskbar));
            }
        }
        /// <summary>
        /// Состояние окна
        /// </summary>
        public WindowState WindowState
        {
            get => windowState;
            set
            {
                windowState = value;
                OnPropertyChanged(nameof(windowState));
            }
        }
        /// <summary>
        /// Видимость
        /// </summary>
        public Visibility Visibility
        {
            get => visibility;
            set
            {
                visibility = value;
                OnPropertyChanged(nameof(visibility));
            }
        }
        #endregion
    }
}