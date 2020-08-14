namespace WindowLoginApplication
{
    #region usings

    using System;
    using System.Windows.Input;

    #endregion

    #region class

    /// <summary>
    ///     RelayLoginCommand class to managed login button event click.
    /// </summary>
    public class RelayLoginCommand : ICommand
    {

        /// <summary>
        ///     Action property.
        /// </summary>
        public Action<Tuple<object, object>> ActionObject { get; set; }

        /// <summary>
        ///     Constructor of class
        /// </summary>
        /// <param name="execute">Action that wil be executed</param>
        public RelayLoginCommand(Action<Tuple<object, object>> execute)
        {
            this.ActionObject = execute;
        }

        /// <summary>
        ///     Check <see cref="ICommand"/>
        ///     On this case, always can be executed.
        /// </summary>
        /// <param name="parameter">parameter</param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        ///     Check <see cref="ICommand"/>
        /// </summary>
        /// <param name="parameter">parameter</param>
        public void Execute(object parameter)
        {
            ActionObject.Invoke(parameter as Tuple<object, object>);
        }

        /// <summary>
        ///      Check <see cref="ICommand"/>
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }

    #endregion 
}
