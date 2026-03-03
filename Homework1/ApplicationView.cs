namespace Homework1
{
    public class ApplicationView
    {
        public string WriteLogCommand { get; } = "1";
        public string ExitCommand { get; } = "2";

        private Dictionary<string, string> _commands;

        public ApplicationView()
        {
            _commands = new Dictionary<string, string>()
            {
                { WriteLogCommand, "Написать лог" },
                { ExitCommand, "Выйти" }
            };
        }

        public void ShowMenu()
        {
            foreach (KeyValuePair<string, string> command in _commands)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{command.Value} - {command.Key}");
                Console.ResetColor();
            }
        }

        public void ShowInvalidCommandMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неверная команда!");
            Console.ResetColor();
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public string GetMessage()
        {
            string message = Console.ReadLine();

            return message;
        }
    }
}
