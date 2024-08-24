using System.Windows.Input;

namespace sentiment_analyzer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();    
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            inputText.Focus();

            if (InputLanguage.CurrentInputLanguage.Culture.TextInfo.IsRightToLeft)
                inputText.RightToLeft = RightToLeft.Yes;
        }

        private int AnalyzeParagraphPositivity(String[] sentences) {
            int positive = 0;
            
            foreach (String sentence in sentences) positive += MLUtil.Predict(sentence);
            
            return positive*100/sentences.Length;
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            if (!MLUtil.DoesModelExists())
            {
                inputText.Text = "";
                MessageBox.Show("Model does not exist. Please train the model first.");
                return;
            }

            if (inputText.TextLength == 0)
            {
                result.Text = "What Do You Have?";
                result.ForeColor = Color.Black;

                unicodeEmoji.Text = "🤔";
                unicodeEmoji.ForeColor = Color.Black;

                paragraphStatus.Text = "0 Characters, 0 Words, 0 Sentences";
                return;
            }

            String paragraph = inputText.Text;

            String[] sentences = paragraph.Split(new char[] { '.', '?', '!', ',','\n', '،' });

            sentences = sentences.Where(sentence => !String.IsNullOrEmpty(sentence)).ToArray();
            if (sentences.Length == 0) return;

            int positivtyPercent = AnalyzeParagraphPositivity(sentences);

            if (positivtyPercent > 50)
            {
                result.Text = positivtyPercent + "% Positive";
                result.ForeColor = Color.Green;

                unicodeEmoji.Text = "😃";
                unicodeEmoji.ForeColor = Color.Green;

            }
            else if (positivtyPercent < 50)
            {
                result.Text = 100 - positivtyPercent + "% Negative";
                result.ForeColor = Color.Red;

                unicodeEmoji.Text = "😠";
                unicodeEmoji.ForeColor = Color.Red;

            }
            else
            {
                result.Text = positivtyPercent + "% Positive/Negative";
                result.ForeColor = Color.DodgerBlue;

                unicodeEmoji.Text = "🤨";
                unicodeEmoji.ForeColor = Color.DodgerBlue;
            }

            int length = inputText.Text.Length;
            int wordsCount = inputText.Text.Split(new char[] {' ', '\n'}).Where(word => !String.IsNullOrEmpty(word)).Count();
            int sentencesCount = sentences.Length;

            paragraphStatus.Text = length + " Characters, " + wordsCount + " Words, " + sentencesCount + " Sentences";
            
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text.ToLower()) {
                case "copy":
                    inputText.Copy();
                    break;

                case "cut":
                    inputText.Cut();
                    break;

                case "paste":
                    inputText.Paste();
                    break;

                case "select all":
                    inputText.SelectAll();
                    break;
            }
        }

        private void inputText_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                if (InputLanguage.CurrentInputLanguage.Culture.TextInfo.IsRightToLeft)
                    inputText.RightToLeft = RightToLeft.Yes;
                else inputText.RightToLeft = RightToLeft.No;
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
        }
    }
}