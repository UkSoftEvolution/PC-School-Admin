using System.Windows.Forms;

namespace PC_School_Admin.Other
{
    /// <summary>
    /// Класс для работы программы в трее
    /// </summary>
    public class Notify
    {
        #region Fields
        private NotifyIcon notifyIcon; //Работа с треем
        #endregion

        #region Constructors
        /// <summary>
        /// Стандартный конструктор для инициализации данных
        /// </summary>
        public Notify()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Text = "PC School Admin";
            notifyIcon.Icon = Properties.Resources.School;
            notifyIcon.Visible = true;
        }
        #endregion
    }
}