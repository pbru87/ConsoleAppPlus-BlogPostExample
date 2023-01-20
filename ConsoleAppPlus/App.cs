using Microsoft.Extensions.Configuration;

namespace ConsoleAppPlus
{
    internal class App
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region CTORs
        public App(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Public Methods
        public async Task Run(string[] args)
        {
            Console.WriteLine(_configuration["HelloWorld"]);
            Console.WriteLine();
            Console.WriteLine("Please look for 'ToDo' in the code to get started quickly with this project template!");
            Console.ReadKey();
        }
        #endregion
    }
}
