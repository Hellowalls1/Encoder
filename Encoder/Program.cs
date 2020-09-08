using System;

namespace Encoder
{
    class Program
    {
        static void Main(string[] args)
        {

            void runIt()
            {
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Console.WriteLine("Welcome to Encoder!");
                Console.WriteLine("About: Encoder is a console application that allows you to encrypt a message one word at a time.");

                Console.WriteLine("Begin by entering a word.");
                //storing answer in variable
                string message = Console.ReadLine();
                string loweredMessage = message.ToLower();
                //creating an array of characters called secret message. Turning "message" into an array of characters
                char[] secretMessage = loweredMessage.ToCharArray();

                //creating a new empty array called encrypted message. it has the length in characters of secret message 
                char[] encryptedMessage = new char[secretMessage.Length];

                //     creating a for loop that loops through each letter of secretMessage and stores each letter in a variable called letter.  
                //     - It then finds the index of that letter)in alphabet and stores that in the indexOfLetter variable
                // - After finding the value of index of ;etter and storing in the indexOfLetter variable we will encrypt that value by adding three to it and storing that new index in a new variable called newLetterPosition
                // -Next get the new letter value and store in value encodedLetter by passing newLetterPosition as the index value in Alphabet
                // -next give encodedLetter an index value in encrypted message. It will do this for each letter in secret message since this is a for loop
                // -the % is taking the remainder of (indexOfLetter + 3) which is devided by index total of alphabet.length(25) and assigning the remainder value as the new character (z is 28 remainder of 3 making it c)


                for (int i = 0; i < secretMessage.Length; i++)
                {
                    char letter = secretMessage[i];
                    int indexOfLetter = Array.IndexOf(alphabet, letter);
                    int newLetterPosition = (indexOfLetter + 3) % alphabet.Length;
                    char encodedLetter = alphabet[newLetterPosition];
                    encryptedMessage[i] = encodedLetter;
                }

                //joining the characters saved in encrypted message array into a message

                string encodedString = String.Join(" ", encryptedMessage);
                Console.WriteLine($"Your encoded message is {encodedString}");
                Console.WriteLine("Would you like to enter another word? Answer yes or no.");
                string yourAnswer = Console.ReadLine();
                string lowerAnswer = yourAnswer.ToLower();
                if (lowerAnswer == "yes")
                {
                    runIt();
                }
                else if (lowerAnswer == "no")
                {
                    Console.WriteLine("Thank you for using Encoder. Goodbye.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("For safety purposes we are kicking you out of the application.");
                    Environment.Exit(0);
                }

            }
            runIt();
        }
    }
}
