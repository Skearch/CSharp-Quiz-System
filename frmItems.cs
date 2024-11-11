using CSharp_Quiz_System.Objects;

namespace CSharp_Quiz_System
{
    public partial class frmItems : Form
    {
        private MultipleChoiceQuestion[] MultipleChoiceQuestion;
        private TrueFalseQuestion[] TrueFalseQuestion;
        private string Title;

        private List<KeyValuePair<string, string>> MultipleChoiceQuestionList = new();
        private List<KeyValuePair<string, bool>> TrueFalseQuestionList = new();

        private int seconds;

        public frmItems(string title, MultipleChoiceQuestion[] multipleChoiceQuestion, TrueFalseQuestion[] trueFalseQuestion)
        {
            InitializeComponent();
            MultipleChoiceQuestion = multipleChoiceQuestion;
            TrueFalseQuestion = trueFalseQuestion;
            Title = title;
        }


        private void frmItems_Load(object sender, EventArgs e)
        {
            tmrQuiz.Enabled = true;
            lblTitle.Text = Title;

            int currentRow = 1;

            for (int i = 0; i < MultipleChoiceQuestion.Length; i++)
            {
                AddMultipleChoiceQuestion(MultipleChoiceQuestion[i], currentRow);

                string question = MultipleChoiceQuestion[i].Question;
                string answer = MultipleChoiceQuestion[i].Choices[MultipleChoiceQuestion[i].CorrectAnswerIndex];
                MultipleChoiceQuestionList.Add(new KeyValuePair<string, string>(question, answer));

                currentRow++;
            }

            for (int i = 0; i < TrueFalseQuestion.Length; i++)
            {
                AddTrueFalseQuestion(TrueFalseQuestion[i], currentRow);

                string question = TrueFalseQuestion[i].Question;
                bool answer = TrueFalseQuestion[i].CorrectAnswer;
                TrueFalseQuestionList.Add(new KeyValuePair<string, bool>(question, answer));

                currentRow++;
            }

            for (int i = 2; i < tableLayoutPanel1.RowCount; i++)
                tableLayoutPanel1.RowStyles[i].SizeType = SizeType.AutoSize;

            tableLayoutPanel1.Refresh();
        }

        private void AddMultipleChoiceQuestion(MultipleChoiceQuestion question, int row)
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.CadetBlue;
            panel.AutoSize = true;

            Point point = new Point(20, 20);

            Label questionLabel = new Label { Text = question.Question };
            questionLabel.Dock = DockStyle.Top;
            panel.Controls.Add(questionLabel);

            for (int i = 0; i < question.Choices.Count; i++)
            {
                RadioButton choiceRadioButton = new RadioButton { Text = question.Choices[i] };
                choiceRadioButton.Location = point;
                panel.Controls.Add(choiceRadioButton);
                point.Y = point.Y + 20;
            }

            tableLayoutPanel1.Controls.Add(panel, row, 0);
        }

        private void AddTrueFalseQuestion(TrueFalseQuestion question, int row)
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.CadetBlue;
            panel.AutoSize = true;

            Point point = new Point(20, 20);

            Label questionLabel = new Label { Text = question.Question };
            questionLabel.Dock = DockStyle.Top;
            panel.Controls.Add(questionLabel);

            CheckBox trueFalseCheckbox = new CheckBox { Text = "True/False" };
            trueFalseCheckbox.Location = point;
            panel.Controls.Add(trueFalseCheckbox);
            tableLayoutPanel1.Controls.Add(panel, row, 0);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int score = 0;
            int total = MultipleChoiceQuestion.Count() + TrueFalseQuestion.Count();

            foreach (Panel panel in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                score += panel.Controls
                    .OfType<RadioButton>()
                    .Where(rb => rb.Checked)
                    .Sum(rb => MultipleChoiceQuestionList.Any(q => q.Value == rb.Text) ? 1 : 0);
            }

            foreach (Panel panel in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                Label? questionLabel = panel.Controls.OfType<Label>().FirstOrDefault();
                CheckBox? trueFalseCheckbox = panel.Controls.OfType<CheckBox>().FirstOrDefault();

                if (questionLabel != null && trueFalseCheckbox != null)
                {
                    string question = questionLabel.Text;
                    bool userAnswer = trueFalseCheckbox.Checked;

                    if (TrueFalseQuestionList.Any(q => q.Key == question && q.Value == userAnswer))
                        score++;
                }
            }

            tmrQuiz.Enabled = false;

            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;

            string formattedTime = $"{minutes:00}:{remainingSeconds:00}";
            MessageBox.Show($"Score: {score}/{total} \nTime: {formattedTime}");

            new frmMain().Show();
            this.Hide();
        }

        private void tmrQuiz_Tick(object sender, EventArgs e) => seconds++;

        private void frmItems_FormClosing(object sender, FormClosingEventArgs e) => Environment.Exit(0);
    }
}