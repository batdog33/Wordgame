using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random
            Random random = new Random();

            //Wordlists
            List<string> easyWords = new List<string>();
            List<string> intermediateWords = new List<string>();
            List<string> hardWords = new List<string>();

            //temp list
            List<char> tempList = new List<char>();

            //Fill wordlists
            //easy words
            easyWords.Add("god");
            easyWords.Add("eye");
            easyWords.Add("any");
            easyWords.Add("her");
            easyWords.Add("iron");
            easyWords.Add("key");
            easyWords.Add("unit");
            easyWords.Add("yard");
            easyWords.Add("zero");
            easyWords.Add("juice");

            //intermediate words
            intermediateWords.Add("equal");
            intermediateWords.Add("anything");
            intermediateWords.Add("education");
            intermediateWords.Add("freedom");
            intermediateWords.Add("chocolate");
            intermediateWords.Add("holiday");
            intermediateWords.Add("measure");
            intermediateWords.Add("mountain");
            intermediateWords.Add("probably");
            intermediateWords.Add("stomach");

            //hard words
            hardWords.Add("grandfather");
            hardWords.Add("comfortable");
            hardWords.Add("furniture");
            hardWords.Add("education");
            hardWords.Add("examination");
            hardWords.Add("neighbour");
            hardWords.Add("telephone");
            hardWords.Add("successful");
            hardWords.Add("substance");
            hardWords.Add("extremely");

            bool restartProgram = true;
            while (restartProgram == true)
            {
                //Introduction
                Console.WriteLine("Hi! Welcome to the wordgame!");
                Console.ReadKey();
                Console.WriteLine(" ");
                Console.WriteLine("Essentially, this will be something for practice, but may be another person's game.");
                Console.ReadKey();
                Console.WriteLine(" ");
                Console.WriteLine("So let's begin:");

                //The game
                int currentStage = 1;
                bool stageCompleted = false;
                while (stageCompleted == false)
                {
                    //List for letter that will be presented
                    List<char> lettersPresented = new List<char>();

                    //Random letters
                    List<char> wordChars = new List<char>();
                    wordChars.Add('a');
                    wordChars.Add('b');
                    wordChars.Add('c');
                    wordChars.Add('d');
                    wordChars.Add('e');
                    wordChars.Add('f');
                    wordChars.Add('g');
                    wordChars.Add('h');
                    wordChars.Add('i');
                    wordChars.Add('j');
                    wordChars.Add('k');
                    wordChars.Add('l');
                    wordChars.Add('m');
                    wordChars.Add('n');
                    wordChars.Add('o');
                    wordChars.Add('p');
                    wordChars.Add('q');
                    wordChars.Add('r');
                    wordChars.Add('s');
                    wordChars.Add('t');
                    wordChars.Add('u');
                    wordChars.Add('v');
                    wordChars.Add('w');
                    wordChars.Add('x');
                    wordChars.Add('y');
                    wordChars.Add('z');

                    //Introduce stage
                    Console.WriteLine(" ");
                    Console.WriteLine("Stage " + currentStage);
                    Console.WriteLine("================================");
                    Console.WriteLine(" ");

                    Console.ReadKey();

                    //Pick an easy word from easyWords list
                    string stageWord = easyWords[random.Next(easyWords.Count)];

                    foreach (char i in stageWord)
                    {
                        lettersPresented.Add(i);
                    }
                    //Populate the list for - Letters presented in a stage
                    for (int i = 0; i < 10; i++)
                    {
                        lettersPresented.Add(wordChars[random.Next(10)]);
                    }
                    int indexPicker;
                    //Shuffle list
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < lettersPresented.Count; j++)
                        {
                            indexPicker = random.Next(lettersPresented.Count);
                            tempList.Add(lettersPresented.ElementAt(indexPicker));
                            lettersPresented.Remove(lettersPresented.ElementAt(indexPicker));
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < tempList.Count; j++)
                        {
                            indexPicker = random.Next(tempList.Count);
                            lettersPresented.Add(tempList.ElementAt(indexPicker));
                            tempList.Remove(tempList.ElementAt(indexPicker));
                        }
                    }
                    bool userAdvance = false;
                    while (userAdvance == false)
                    {
                        //Print letters 
                        for (int i = 0; i < lettersPresented.Count; i++)
                        {
                            Console.Write(" | " + lettersPresented[i]);
                        }
                        Console.WriteLine(" ");
                        Console.Write("The word is: ");
                        string userGuess = Console.ReadLine();
                        Console.WriteLine(" ");
                        if (userGuess == stageWord)
                        {
                            currentStage = (currentStage + 1);
                            easyWords.Remove(userGuess);
                            userAdvance = true;
                        }
                        else if (userGuess.Length < stageWord.Length)
                        {
                            Console.WriteLine("Not correct.");
                            Console.WriteLine("You are using too few letters.");
                            Console.WriteLine(" ");
                        }
                        else if (userGuess.Length > stageWord.Length)
                        {
                            Console.WriteLine("Not correct.");
                            Console.WriteLine("You are using too many letters.");
                            Console.WriteLine(" ");
                        }
                        else if (userGuess.Length == stageWord.Length)
                        {
                            Console.WriteLine("Not correct.");
                            Console.WriteLine(" ");
                        }
                        else if (userGuess == "skip")
                        {
                            Console.WriteLine("You chose to skip. The word was '" + stageWord + "'.");
                            easyWords.Remove(userGuess);
                            userAdvance = true;
                        }

                    }
                    if (currentStage == 10)
                    {
                        Console.WriteLine("You've completed all the stages for the 'easy' words.");
                        Console.WriteLine("Now prepare yourself for the intermediate ones.");
                        Console.WriteLine(" ");
                        restartProgram = false;
                        break;
                    }
                }
                //End result possibly later

                Console.ReadKey();
            }

        }
    }
}