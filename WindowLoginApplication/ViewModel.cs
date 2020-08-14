namespace WindowLoginApplication
{
    #region usings

    using System.Net;
    using System.Security;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System;

    #endregion

    #region class

    /// <summary>
    ///     Viewmodel class.
    /// </summary>
    public class ViewModel
    {
        /// <summary>
        ///     Private field for command property.
        /// </summary>
        private RelayLoginCommand _saveAccount;

        /// <summary>
        ///     Command property to login button.
        /// </summary>
        public ICommand SaveAccountCommand
        {
            get
            {
                return _saveAccount ?? (_saveAccount = new RelayLoginCommand(SaveAccount));
            }
        }

        /// <summary>
        ///     Property to validate user insert by user.
        /// </summary>
        public string MyUser { get; set; }

        /// <summary>
        ///     Property to validate password insert by user.
        /// </summary>
        public SecureString MyPassword { get; set; }

        /// <summary>
        ///     Constructor by default
        /// </summary>
        public ViewModel()
        {

        }

        /// <summary>
        ///     Method ot validate the input from the user.
        /// </summary>
        /// <param name="param">Parameter send by command argument</param>
        private void SaveAccount(object param)
        {
            //  1   -   First cast

            var aux = (Tuple<object, object>)param;

            //  2   -   Second cast

            var userControl = (TextBox)aux.Item1;
            var passwordControl = (PasswordBox)aux.Item2;

            // 3    -   Asign values to property.

            MyUser = userControl.Text;
            MyPassword = new NetworkCredential("", passwordControl.Password).SecurePassword;


            // EXTRA:   Make that you want with the given values.
            var message = String.Concat("User: ", MyUser, "\n", "Password: ", new NetworkCredential("", MyPassword).Password);
            MessageBox.Show(message);
        }
    }

    #endregion
}
