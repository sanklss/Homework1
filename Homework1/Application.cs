namespace Homework1
{
    public class Application
    {
        private ApplicationView _applicationView;

        private string _writeLogCommand;
        private string _exitCommand;

        public Application()
        {
            _applicationView = new ApplicationView();

            _writeLogCommand = _applicationView.WriteLogCommand;
            _exitCommand = _applicationView.ExitCommand;
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                _applicationView.ShowMenu();
                string userInput = _applicationView.GetUserInput();

                if (userInput == _writeLogCommand)
                {
                    string message = _applicationView.NewMethod();
                    Logger.WriteLog(message);
                }
                else if (userInput == _exitCommand)
                {
                    isRunning = false;
                }
                else
                {
                    _applicationView.ShowInvalidCommandMessage();
                }
            }
        }
    }
}
