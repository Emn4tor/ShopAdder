using System;
using System.Collections.Generic;

namespace ExampleCWPlugin
{
    public class ShopCategories
    {
        // List of registered categories
        public static List<string> registerCategories = new List<string>();
        // Dictionary for localization keys
        internal static Dictionary<string, string> registerLocales = new Dictionary<string, string>();

        /// <summary>
        /// Initialize the shop categories and log the count.
        /// </summary>
        internal static void Initialize()
        {
            // Register a test category
            RegisterCategory("Test");

            // Log the count
            Console.WriteLine($"Registered {registerCategories.Count} Shop Categories");
        }

        /// <summary>
        /// Registers a new shop item category.
        /// </summary>
        /// <param name="name">Name of the new category.</param>
        /// <returns>The name of the newly registered category.</returns>
        public static string RegisterCategory(string name)
        {
            if (!registerCategories.Contains(name))
            {
                registerCategories.Add(name);
                registerLocales[name] = name;

                Console.WriteLine($"Registered new category: {name}");
            }
            else
            {
                Console.WriteLine($"Category '{name}' is already registered.");
            }

            return name;
        }

        /// <summary>
        /// Retrieves the list of all registered categories.
        /// </summary>
        /// <returns>A list of registered category names.</returns>
        public static List<string> GetRegisteredCategories()
        {
            return new List<string>(registerCategories);
        }
        

    }
}