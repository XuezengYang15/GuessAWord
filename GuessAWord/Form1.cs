namespace GuessAWord
{
    public partial class Form1 : Form
    {

        string[] words = { "happy", "comments", "elements", "statement",
                           "truck", "trout", "success", "winner"};
        string correctWord = "";
        int totalGuess = 0;
        int correctGuess = 0;
        int correctWordLength = 0;
        int numOfGuesses = 0;
        string letter = "";
        string stringValidator = "";
        char[] asteriskCharArray;
        string asteriskString = "";
        char letterChar;
        string previousGuessLetter = "";
        

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            debugger.Visible = false;
            outputMessage.Text = "Press start to begin.";
            submitButton.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //resets the variables when clicking start.
            correctGuess = 0;
            totalGuess = 0;
            asteriskString = "";
            previousGuessLetter = "";
            textBox.Text = "";

            //Randomly selects the word
            correctWord = words[rnd.Next(0, 7)];
            correctWordLength = correctWord.Length;

            asteriskCharArray = new char[correctWordLength];

            numOfGuesses = correctWordLength * 2;

            submitButton.Visible = true;

            startButton.Visible = false;

            debugger.Visible = false;

            //Creating the asterisk string the length of correct word
            for (int i = 0; i < correctWordLength; i++)
            {
                asteriskCharArray[i] = '*';
                asteriskString = asteriskString + asteriskCharArray[i];
            }

            hiddenWord.Text = asteriskString;

            //This lets the user know how many guesses they have.
            outputMessage.Text = "You have " + numOfGuesses + " guesses.";

            submitButton.Visible = true;

            //debugger to the hidden word.  I will erase later.
            debugger.Text = correctWord;

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox.MaxLength = 1;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //If the textbox is empty when submitting, it doesn't cause an error.
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return;
            }

            asteriskString = "";

            letterChar = textBox.Text[0];

            letter = letterChar.ToString();

            textBox.Text = "";

            //Inserts the correct letter into the correct index(es)
            for (int i = 0; i < correctWordLength; i++)
            {
                //Must not contain previous guessed letter and be a letter in the hidden word
                if (correctWord[i] == letterChar && (!previousGuessLetter.Contains(letter)))
                {
                    asteriskCharArray[i] = letterChar;
                    outputMessage.Text = "Yes, that is the correct letter!";
                    
                }
            }

            //print out the asterisk string onto the hidden box
            for (int i = 0; i < correctWordLength; i++)
            {
                asteriskString = asteriskString + asteriskCharArray[i];
                hiddenWord.Text = asteriskString;

                //Used to check if asterisk is still in the string.
                stringValidator = asteriskString;
            }

            //Increments the total guess and/or correct guess depending on result
            if (!correctWord.Contains(letter))
            {
                outputMessage.Text = "No, that is the wrong letter.";
                totalGuess++;
            }
            else if (previousGuessLetter.Contains(letter))
            {
                outputMessage.Text = "Although that's correct, you " +
                    "already guessed that";
             
                totalGuess++;
            }
            else
            {
                correctGuess++;
                totalGuess++;
            }

            //If the total guess reaches the max number of guesses, the user loses.
            if (totalGuess > (numOfGuesses - 1))
            {
                outputMessage.Text = "You lose! Press start to play again.";
                totalGuess = 0;
                correctGuess = 0;
                submitButton.Visible = false;
                startButton.Visible = true;
                debugger.Visible = false;
                previousGuessLetter = "";
                textBox.Text = "";
            }

            if (!stringValidator.Contains("*"))
            {
                outputMessage.Text = "You WIN!!! Press start to play again.";
                totalGuess = 0;
                correctGuess = 0;
                submitButton.Visible = false;
                textBox.Text = "";
                startButton.Visible = true;
                debugger.Visible = false;
                previousGuessLetter = "";
            }

            //adds the previous guessed letters into a string
            if (correctWord.Contains(letter))
            {
                previousGuessLetter = previousGuessLetter + letter;
            }

            //prints out the ratio of guesses
            ratioOfGuesses.Text = correctGuess + " : " + totalGuess;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            debugger.Visible = true;
            outputMessage.Text = "CHEATER!!!";
        }
    }
}