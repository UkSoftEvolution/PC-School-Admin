using PC_School_Admin.Other;
using System.Threading.Tasks;
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
        #endregion

        #region Constructors
        /// <summary>
        /// Конструктор для RegViewModel
        /// </summary>
        /// <param name="active">Активная страница</param>
        public RegViewModel(ActivePage active)
        {
            this.active = active;
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
            Encryption encryption = new Encryption();
            encryption.Encrypt(obj);
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