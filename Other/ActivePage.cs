using System.Windows.Controls;

namespace PC_School_Admin.Other
{
    /// <summary>
    /// Класс для реализации перехода между страницами приложения
    /// </summary>
    public class ActivePage : MVVM
    {
        #region Fields
        private Page active; //Активная страница
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