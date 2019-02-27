using PC_School_Admin.Other;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PC_School_Admin.ViewModel
{
    /// <summary>
    /// ViewModel: Класс для Binding с RegView
    /// </summary>
    public class RegViewModel : MVVM
    {
        #region Fields
        private ActivePage active; //Активная страница
        private string name; //Имя компьютера
        private bool enable; //Доступность полей
        private Visibility visibile; //Видимость ошибки
        private string messageError; //Сообщение об ошибке
        #endregion

        #region Constructors
        /// <summary>
        /// Конструктор для RegViewModel
        /// </summary>
        /// <param name="active">Активная страница</param>
        public RegViewModel(ActivePage active)
        {
            this.active = active;
            Enable = true;
            Visibile = Visibility.Hidden;
        }
        #endregion

        #region Function
        /// <summary>
        /// Регистрация
        /// </summary>
        /// <param name="name">Имя компьютера</param>
        /// <param name="obj">Объект</param>
        private void CheckIn(string name, object obj)
        {
            Enable = false;
            if (Visibile == Visibility.Visible)
                Visibile = Visibility.Hidden;

            if (Name == null)
            {
                MessageError = "Имя введено неправильно";
                Visibile = Visibility.Visible;
            }
            else
            {
                if (Name.Length == 0)
                {
                    MessageError = "Имя введено неправильно";
                    Visibile = Visibility.Visible;
                }
                else
                {
                    if ((obj as PasswordBox).Password.Length == 0)
                    {
                        MessageError = "Код доступа введен неправильно";
                        Visibile = Visibility.Visible;
                    }
                    else
                    {
                        Encryption encryption = new Encryption();
                        encryption.Encrypt(obj);
                    }
                }
            }
            Enable = true;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Активная страница
        /// </summary>
        public Page Active
        {
            set => active.Active = value;
        }
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
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string MessageError
        {
            get => messageError;
            set
            {
                messageError = value;
                OnPropertyChanged(nameof(messageError));
            }
        }
        #endregion

        #region Command
        /// <summary>
        /// Комманда на собитие Click кнопки ПРОДОЛЖИТЬ
        /// </summary>
        public RelayCommand ContinueClick => new RelayCommand(obj =>
        {
            Task.Factory.StartNew(() =>
            {
                CheckIn(Name, obj);
            });
        });
        #endregion
    }
}