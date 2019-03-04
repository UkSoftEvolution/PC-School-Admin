using System;
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
        private StateWindow stateWindow; //Состояние окна
        #endregion

        #region Constructors
        /// <summary>
        /// Стандартный конструктор для инициализации данных
        /// </summary>
        public Notify(StateWindow stateWindow)
        {
            this.stateWindow = stateWindow;
            notifyIcon = new NotifyIcon();
            notifyIcon.Text = "PC School Admin";
            notifyIcon.Icon = Properties.Resources.School;
            notifyIcon.Click += NotifyIcon_Click;
            notifyIcon.Visible = true;
        }
        #endregion

        #region Functions
        /// <summary>
        /// Всплывающая подсказка
        /// </summary>
        /// <param name="Text">Текст</param>
        /// <param name="Title">Заголовк</param>
        /// <param name="Show">Отображение в секундах</param>
        private void BalloonTip(string Text, string Title, int Show)
        {
            notifyIcon.BalloonTipText = Text;
            notifyIcon.BalloonTipTitle = Title;
            notifyIcon.ShowBalloonTip(Show);
        }
        #endregion

        #region Events
        /// <summary>
        /// Событие по клику на значёк в трее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            if (stateWindow.ShowInTaskbar)
            {
                stateWindow.Tray(false);
                BalloonTip("Программа теперь работает в фоновом режиме", "Фоновый режим", 12);
            }
            else
                stateWindow.Tray(true);
        }
        #endregion
    }
}