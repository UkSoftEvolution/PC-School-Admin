using PC_School_Admin.Other;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PC_School_Admin.ViewModel
{
    /// <summary>
    /// ViewModel: Класс для Binding с AuthView
    /// </summary>
    public class AuthViewModel : MVVM
    {
        #region Fields
        private string name; //Имя компьютера
        private bool enable; //Доступность полей
        private Visibility visibile; //Видимость ошибки
        #endregion

        #region Constructors
        /// <summary>
        /// Конструктор для RegViewModel
        /// </summary>
        public AuthViewModel()
        {
            Enable = true;
            Visibile = Visibility.Hidden;
            Name = Properties.Auth.Default.Name;
        }
        #endregion

        #region Function
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="obj">Объект</param>
        private void SignIn(object obj)
        {
            Enable = false;
            if (Visibile == Visibility.Visible)
                Visibile = Visibility.Hidden;

            if ((obj as PasswordBox).Password.Length == 0)
                Visibile = Visibility.Visible;
            else
            {
                Encryption encryption = new Encryption();
                if (Properties.Auth.Default.Password == encryption.Encrypt(obj))
                { }
                else
                    Visibile = Visibility.Visible;
            }
            Enable = true;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Имя компьютера
        /// </summary>
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(name));
            }
        }
        /// <summary>
        /// Доступность полей
        /// </summary>
        public bool Enable
        {
            get => enable;
            set
            {
                enable = value;
                OnPropertyChanged(nameof(enable));
            }
        }
        /// <summary>
        /// Видимость ошибки
        /// </summary>
        public Visibility Visibile
        {
            get => visibile;
            set
            {
                visibile = value;
                OnPropertyChanged(nameof(visibile));
            }
        }
        #endregion

        #region Command
        /// <summary>
        /// Комманда на собитие Click кнопки ПОДТВЕРДИТЬ
        /// </summary>
        public RelayCommand ConfirmClick => new RelayCommand(obj =>
        {
            Task.Factory.StartNew(() =>
            {
                SignIn(obj);
            });
        });
        #endregion
    }
}