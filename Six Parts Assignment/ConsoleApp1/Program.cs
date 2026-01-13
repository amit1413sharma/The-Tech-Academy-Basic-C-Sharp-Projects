using System;                    // Gives access to Console and basic system types
using System.Collections.Generic; // Gives access to List<T> and HashSet<T>

namespace ConsoleAppAssignmentFull
{
    class Program
    {
        static void Main(string[] args)
        {
            // =====================================================
            // PART 1
            // =====================================================

            // Create a one-dimensional array of strings
            string[] words = { "Apple", "Banana", "Cherry", "Date" };

            // Ask the user to input some text
            Console.Write("Enter some text to append to each word: ");

            // Read the user's input from the console
            string userInput = Console.ReadLine();

            // Loop through the array and append user input to each element (no output in this loop)
            for (int i = 0; i < words.Length; i++)
            {
                // Update the current array element by appending the user's text
                words[i] = words[i] + " " + userInput;
            }

            // Print a heading for Part 1 output
            Console.WriteLine("\nPART 1 OUTPUT:");

            // Second loop that prints off each string in the array one at a time
            for (int i = 0; i < words.Length; i++)
            {
                // Print the updated string at index i
                Console.WriteLine(words[i]);
            }

            // =====================================================
            // PART 2
            // =====================================================

            // Print a heading for Part 2 output
            Console.WriteLine("\nPART 2 OUTPUT:");

            // Create a counter to track which array index we are printing
            int counter = 0;

            // Infinite loop (while true)
            // FIX: We stop the infinite loop by using a break condition once counter reaches the array length
            while (true)
            {
                // Print the current array element
                Console.WriteLine(words[counter]);

                // Move to the next index
                counter++;

                // If we have printed all items, break out of the infinite loop to prevent it from running forever
                if (counter >= words.Length)
                {
                    break; // This is what fixes the infinite loop so it executes properly
                }
            }

            // =====================================================
            // PART 3
            // =====================================================

            // Print a heading for the < operator loop
            Console.WriteLine("\nPART 3 OUTPUT ( < operator ):");

            // Loop where the comparison uses the < operator
            for (int i = 0; i < words.Length; i++)
            {
                // Print each array element
                Console.WriteLine(words[i]);
            }

            // Print a heading for the <= operator loop
            Console.WriteLine("\nPART 3 OUTPUT ( <= operator ):");

            // Create an index variable for the while loop
            int index = 0;

            // Loop where the comparison uses the <= operator (stops at last valid index)
            while (index <= words.Length - 1)
            {
                // Print the array element at the current index
                Console.WriteLine(words[index]);

                // Increment index to continue iterating
                index++;
            }

            // =====================================================
            // PART 4
            // =====================================================

            // Create a list of unique strings
            List<string> fruits = new List<string>()
            {
                "Apple",
                "Banana",
                "Cherry",
                "Date",
                "Mango"
            };

            // Ask the user to input text to search for in the list
            Console.Write("\nEnter a fruit to search for (Part 4): ");

            // Read the user's search input
            string searchInput = Console.ReadLine();

            // Create a flag to track whether we found a match
            bool found = false;

            // Loop that iterates through the list and checks for a match
            for (int i = 0; i < fruits.Count; i++)
            {
                // Check if the current list item matches the user's input (case-insensitive)
                if (fruits[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
                {
                    // Display the index of the matching item
                    Console.WriteLine($"Match found at index: {i}");

                    // Update the flag because we found a match
                    found = true;

                    // Stop the loop once a match has been found
                    break;
                }
            }

            // If no match was found, tell the user their input is not on the list
            if (!found)
            {
                Console.WriteLine("The item you entered is not on the list.");
            }

            // =====================================================
            // PART 5
            // =====================================================

            // Create a list of strings that has duplicates
            List<string> colors = new List<string>()
            {
                "Red",
                "Blue",
                "Green",
                "Red",
                "Yellow",
                "Blue"
            };

            // Ask the user to select text to search for in the list
            Console.Write("\nEnter a color to search for (Part 5): ");

            // Read the user's input for Part 5
            string colorInput = Console.ReadLine();

            // Create a flag to track whether any matches are found
            bool matchFound = false;

            // Loop that iterates through the list and displays ALL indices containing matching text
            for (int i = 0; i < colors.Count; i++)
            {
                // Check if the current item matches the user's input (case-insensitive)
                if (colors[i].Equals(colorInput, StringComparison.OrdinalIgnoreCase))
                {
                    // Print the index where a match was found
                    Console.WriteLine($"Match found at index: {i}");

                    // Set the flag to true because we found at least one match
                    matchFound = true;

                    // NOTE: No break statement here so we can find multiple matches
                }
            }

            // If no matches were found, tell the user their input is not on the list
            if (!matchFound)
            {
                Console.WriteLine("The item you entered is not on the list.");
            }

            // =====================================================
            // PART 6
            // =====================================================

            // Create a list of strings that has at least two identical strings (duplicates)
            List<string> letters = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "C"
            };

            // Print a heading for Part 6 output
            Console.WriteLine("\nPART 6 OUTPUT (foreach duplicate check):");

            // Create a HashSet to keep track of items we've already seen
            // HashSet is great for fast "already seen" checks
            HashSet<string> seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Foreach loop that evaluates each item in the list
            foreach (string letter in letters)
            {
                // If Add returns true, the item was NOT already in the set (unique so far)
                if (seen.Add(letter))
                {
                    // Print that the item is unique
                    Console.WriteLine($"{letter} - this item is unique");
                }
                else
                {
                    // If Add returns false, the item was already seen (duplicate)
                    Console.WriteLine($"{letter} - this item is a duplicate");
                }
            }

            // Keep the console window open so the user can see results
            Console.ReadLine();
        }
    }
}
