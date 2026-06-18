using System;

namespace LibLibraryTest
{
    /// <summary>
    /// A dummy class that prints messages to the console
    /// </summary>
    public class LibClass
    {
        /// <summary>
        /// Prints a greeting message to the console
        /// </summary>
        /// <param name="name">The name to greet</param>
        public void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello from LibLibraryTest! Welcome, {name}!");
        }

        /// <summary>
        /// Prints a message to the console
        /// </summary>
        /// <param name="message">The message to print</param>
        public void PrintMessage(string message)
        {
            Console.WriteLine($"[LibLibraryTest] {message}");
        }

        /// <summary>
        /// Gets library version information
        /// </summary>
        /// <returns>Version information string</returns>
        public string GetVersionInfo()
        {
            return "LibLibraryTest v1.0.0 - .NET 8.0";
        }
    }
}
