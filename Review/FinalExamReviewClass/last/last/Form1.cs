using System.Text.RegularExpressions;
using Last2;

namespace last
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRequired.Click += Validation_Click;
            btnMinLength.Click += Validation_Click;
            btnAlphabetic.Click += Validation_Click;
            btnNumeric.Click += Validation_Click;
            btnHasPunctuation.Click += Validation_Click;
        }

        private void Validation_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton && txtInputText != null) // Check if sender is a Button and txtInputText is not null
            {
                string inputText = txtInputText.Text;
                rtbValidation.Clear();

                switch (clickedButton.Name)
                {
                    case "btnRequired":
                        if (string.IsNullOrEmpty(inputText))
                        {
                            rtbValidation.AppendText("Input text is required\n");
                        }
                        break;

                    case "btnMinLength":
                        if (inputText.Length < 2)
                        {
                            rtbValidation.AppendText("Text should have at leaste more than 2 characters\n");
                        }
                        break;

                    case "btnAlphabetic":
                        if (!Regex.IsMatch(inputText, @"^[a-zA-Z]+$"))
                        {
                            rtbValidation.AppendText("The input text must contain only alphabetic characters\n");
                        }
                        break;

                    case "btnNumeric":
                        if (!Regex.IsMatch(inputText, @"^\d+$"))
                        {
                            rtbValidation.AppendText("The input text must contain only numeric characters\n");
                        }
                        break;

                    case "btnHasPunctuation":
                        if (!Regex.IsMatch(inputText, @"[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~]"))
                        {
                            rtbValidation.AppendText("The input text must contain atleast 1 puctuation characters\n");
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                string inputText = txtInputText.Text;
                string[] substrings = inputText.Split(' ');

                rtbManipulation.Clear();

                foreach (string substring in substrings)
                {
                    rtbManipulation.AppendText(substring + "\n");
                }
            }
        }

        private void btnLeaveAlphanumeric_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                string inputText = txtInputText.Text;
                string alphanumeric = Regex.Replace(inputText, @"[^a-zA-Z0-9]", "");

                rtbManipulation.Clear();
                rtbManipulation.AppendText(alphanumeric);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidatePlayingCard_Click(object sender, EventArgs e)
        {
            string suit = txtSuit.Text;
            int value;
            if (int.TryParse(txtValue.Text, out value))
            {
                if (PlayingCard.IsValid(suit, value))
                {
                    rtbPayingCards.Text = "Valid";
                }
                else
                {
                    rtbPayingCards.Text = "Invalid";
                }
            }
            else
            {
                rtbPayingCards.Text = "Invalid";
            }
        }

        private List<PlayingCard> allCards = new List<PlayingCard>();

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            string suit = txtSuit.Text;
            int value;
            if (int.TryParse(txtValue.Text, out value))
            {
                if (PlayingCard.IsValid(suit, value))
                {
                    PlayingCard card = new PlayingCard(suit, value);
                    allCards.Add(card);
                    PlayingCard.WriteToFile(allCards);
                    rtbPayingCards.Text = "Written to file";
                }
                else
                {
                    rtbPayingCards.Text = "Invalid";
                }
            }
            else
            {
                rtbPayingCards.Text = "Invalid";
            }
        }
    }
}