using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7_yevhenii
{
    public partial class Form1 : Form
    {

        List<string> correctAnswers = new List<string>()
        {
            "B", "D", "A", "A", "C", "A", "B", "A", "C", "D",
            "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"
        };

        List<string> converter = new List<string>()
        {
            "A", "B", "C", "D"
        };

        static Dictionary<string, List<string>> questions = new Dictionary<string, List<string>>();

        static List<string> questionKeys = new List<string>();

        List<string> userAnswers = new List<string>();

        static string text = System.IO.File.ReadAllText(@"../../questions.txt");

        static int counter = 0;

        public Form1()
        {
            InitializeComponent();
            buttonStarter();
        }

        private void buttonStarter()
        {
            this.button_finish.Enabled = false;
            this.button_start.Enabled = true;
            this.button_next.Enabled = false;
        }

        private void dataCleaner()
        {
            userAnswers.Clear();
            counter = 0;
            questionKeys.Clear();
            questions.Clear();
        }

        private static void fillQuestions()
        {
            string[] questionsAsArray = text.Split(char.Parse("\n"));
            foreach (string question in questionsAsArray)
            {
                var foundIndexes = new List<int>();
                for (int i = question.IndexOf(';'); i > -1; i = question.IndexOf(';', i + 1))
                {
                    foundIndexes.Add(i);
                }
                List<string> answers = new List<string>()
                    {
                        question.Substring(question.IndexOf(":") + 1, foundIndexes[0] - question.IndexOf(":")),
                        question.Substring(foundIndexes[0] + 1, foundIndexes[1] - foundIndexes[0]),
                        question.Substring(foundIndexes[1] + 1, foundIndexes[2] - foundIndexes[1]),
                        question.Substring(foundIndexes[2] + 1, foundIndexes[3] - foundIndexes[2])
                    };
                questions.Add(question.Substring(0, question.IndexOf(":")), answers); 
                questionKeys.Add(question.Substring(0, question.IndexOf(":")));
            }
            Console.WriteLine(questions);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            userAnswers.Add(getSelectedAnswerLetter());
            loadQuestion(counter);
        }

        private string getSelectedAnswerLetter()
        {
            List<RadioButton> radioButtons = new List<RadioButton>() { radio_1, radio_2, radio_3, radio_4 };
            for (int i = 0; i < 4; i++)
            {
                if (radioButtons[i].Checked)
                {
                    return converter[i];
                }
            }
            return "error";
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            this.button_next.Enabled = true;
            this.button_start.Enabled = false;
            dataCleaner();
            List<RadioButton> radioButtons = new List<RadioButton>() { radio_1, radio_2, radio_3, radio_4 };
            turnRadios(radioButtons, true);

            fillQuestions();
            counter = 0;
            loadQuestion(counter);
        }

        private void turnRadios(List<RadioButton> radios, Boolean mode)
        {
            foreach (RadioButton r in radios)
            {
                r.Enabled = mode;
            }
        }

        private void loadQuestion(int idx)
        {
            List<RadioButton> radioButtons = new List<RadioButton>() { radio_1, radio_2, radio_3, radio_4 };
            try
            {
                this.label_question.Text = questionKeys[idx].ToString();
                for (int i = 0; i < 4; i++)
                {
                    radioButtons[i].Text = questions[questionKeys[idx]][i];
                }
                counter++;
            } catch
            {
                turnRadios(radioButtons, false);
                this.button_finish.Enabled = true;
                this.button_next.Enabled = false;
            }
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm(caclPercentage());
            resultForm.ShowDialog();
            button_start_Click(sender, e);
            this.button_finish.Enabled = false; 
        }

        private double caclPercentage()
        {
            double numOfCorrectAnswers = 0;
            for (int i = 0; i < userAnswers.Count; i++)
            {
                if (userAnswers[i] == correctAnswers[i])
                {
                    numOfCorrectAnswers++;
                }
            }
            if (userAnswers.Count == numOfCorrectAnswers)
            {
                return 100.0;
            } else if (numOfCorrectAnswers == 0)
            {
                return 0.0;
            } else
            {
                return (double)(100 / double.Parse((userAnswers.Count - 1).ToString()) * numOfCorrectAnswers);
            }
        }
    }
}
