using CSharp_Quiz_System.Objects;

namespace CSharp_Quiz_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            List<MultipleChoiceQuestion> multipleChoiceQuestions = new List<MultipleChoiceQuestion>();
            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Science: Which of the following is NOT a renewable energy source?",
                new List<string> { "Solar energy", "Wind energy", "Hydroelectric energy", "Fossil fuels" },
                3));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Math: What is the product of 12 and 8?",
                new List<string> { "96", "20", "48", "72" },
                0));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "English: Which sentence is written correctly?",
                new List<string> { "I goed to the store yesterday.", "She is coming tomorrow.", "Him and me played outside.", "We be going to the park." },
                1));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Social Studies: Which of these historical figures is known for leading the American Revolution?",
                new List<string> { "Abraham Lincoln", "George Washington", "Martin Luther King Jr.", "Nelson Mandela" },
                1));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Arts and Music: What is the highest note on a standard piano keyboard?",
                new List<string> { "C", "B", "G", "A" },
                3));

            List<TrueFalseQuestion> trueFalseQuestions = new List<TrueFalseQuestion>();
            trueFalseQuestions.Add(new TrueFalseQuestion(
                "The Earth is the largest planet in the solar system.",
                false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Dogs can see in color.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "The Great Wall of China is visible from space with the naked eye.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Chocolate milk comes from brown cows.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Humans have more bones as babies than as adults.",
               true));

            frmItems frmItems = new frmItems("Quiz: Easy", multipleChoiceQuestions.ToArray(), trueFalseQuestions.ToArray());

            frmItems.Show();
            this.Hide();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            List<MultipleChoiceQuestion> multipleChoiceQuestions = new List<MultipleChoiceQuestion>();
            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Science: Which of the following is NOT a renewable energy source?",
                new List<string> { "Solar energy", "Wind energy", "Hydroelectric energy", "Fossil fuels" },
                3));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Math: What is the product of 12 and 8?",
                new List<string> { "96", "20", "48", "72" },
                0));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "English: Which sentence is written correctly?",
                new List<string> { "I goed to the store yesterday.", "She is coming tomorrow.", "Him and me played outside.", "We be going to the park." },
                1));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Social Studies: Which of these historical figures is known for leading the American Revolution?",
                new List<string> { "Abraham Lincoln", "George Washington", "Martin Luther King Jr.", "Nelson Mandela" },
                1));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Arts and Music: What is the highest note on a standard piano keyboard?",
                new List<string> { "C", "B", "G", "A" },
                3));

            List<TrueFalseQuestion> trueFalseQuestions = new List<TrueFalseQuestion>();
            trueFalseQuestions.Add(new TrueFalseQuestion(
                "The Earth is the largest planet in the solar system.",
                false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Dogs can see in color.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "The Great Wall of China is visible from space with the naked eye.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Chocolate milk comes from brown cows.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Humans have more bones as babies than as adults.",
               true));

            frmItems frmItems = new frmItems("Quiz: Medium", multipleChoiceQuestions.ToArray(), trueFalseQuestions.ToArray());

            frmItems.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            List<MultipleChoiceQuestion> multipleChoiceQuestions = new List<MultipleChoiceQuestion>();
            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Science: Which of the following is NOT a renewable energy source?",
                new List<string> { "Solar energy", "Wind energy", "Hydroelectric energy", "Fossil fuels" },
                3));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Math: What is the product of 12 and 8?",
                new List<string> { "96", "20", "48", "72" },
                0));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "English: Which sentence is written correctly?",
                new List<string> { "I goed to the store yesterday.", "She is coming tomorrow.", "Him and me played outside.", "We be going to the park." },
                1));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Social Studies: Which of these historical figures is known for leading the American Revolution?",
                new List<string> { "Abraham Lincoln", "George Washington", "Martin Luther King Jr.", "Nelson Mandela" },
                1));

            multipleChoiceQuestions.Add(new MultipleChoiceQuestion(
                "Arts and Music: What is the highest note on a standard piano keyboard?",
                new List<string> { "C", "B", "G", "A" },
                3));

            List<TrueFalseQuestion> trueFalseQuestions = new List<TrueFalseQuestion>();
            trueFalseQuestions.Add(new TrueFalseQuestion(
                "The Earth is the largest planet in the solar system.",
                false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Dogs can see in color.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "The Great Wall of China is visible from space with the naked eye.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Chocolate milk comes from brown cows.",
               false));

            trueFalseQuestions.Add(new TrueFalseQuestion(
               "Humans have more bones as babies than as adults.",
               true));

            frmItems frmItems = new frmItems("Quiz: Hard", multipleChoiceQuestions.ToArray(), trueFalseQuestions.ToArray());

            frmItems.Show();
            this.Hide();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) => Environment.Exit(0);
    }
}
