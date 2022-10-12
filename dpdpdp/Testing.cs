using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace dpdpdp
{
    public partial class Testing : Form
    {

        List<int> useQuestions = new List<int>();
        XDocument doc = new XDocument();
        XElement root;
        List<string> trueAnswers = new List<string>();
        List<int> rndAnswers = new List<int>();
        Random rndAnsw = new Random((int)DateTime.Now.Ticks);
        int currentQusetion = 1;
        int maxQuestion;
        string type;
        int timeForQue;
        int waveTime;
        XElement question;
        int x = 10;
        int y = 10;
        double trueAsking = 0;
        double score;
        string test = "";
        bool notEmpty = false;

        public Testing()
        {
            InitializeComponent();
            if (currentUser.GetRole() != 4)
                testingTableAdapter1.Fill(usersDBDataSet1.testing);
            LoadTests();
        }

        private void LoadTest()
        {
            useQuestions.Clear();
            pnlChooseTest.Visible = false;
            pnlTesting.Visible = true;
            pnlTesting.Dock = DockStyle.Fill;
            doc = XDocument.Load(Environment.CurrentDirectory + @"\tests\" + test + ".xml");
            root = doc.Element("test");
            trueAsking = 0;
            score = 0;
            currentQusetion = 1;
            maxQuestion = root.Elements().Count();
            btnNextQue.Enabled = true;
            GenQue();
        }

        private void GenQue()
        {
            lblScore.Text = "";
            gbAnswers.Controls.Clear();
            gbAnswers.Enabled = true;
            timer1.Stop();
            trueAnswers.Clear();
            y = 10;

            question = root.Elements().ElementAt(CreateRandom());
            lblQuestion.Text = question.Attribute("text").Value;
            timeForQue = Convert.ToInt32(question.Attribute("time").Value);
            type = question.Attribute("type").Value;
            rndAnswers.Clear();
            switch (type)
            {
                case "radio":
                    GenRadio();
                    break;
                case "check":
                    GenCheck();
                    break;
                case "text":
                    GenText();
                    break;
            }
            lblQuestions.Text = "Вопрос " + currentQusetion + @"/" + 10;
            timer1.Start();
            waveTime = timeForQue * 10;
            time.Maximum = waveTime;
        }

        private int RandomAnswers()
        {
            int n;
            do
            {
                n = rndAnsw.Next(0, 4);
            } while (rndAnswers.Contains(n));
            rndAnswers.Add(n);
            return n;
        }

        private void GenRadio()
        {
            for (int i = 0; i < 4; i++)
            {
                XElement answer = question.Elements().ElementAt(RandomAnswers());
                RadioButton rb = new RadioButton();
                rb.Text = answer.Value;
                if (answer.Attribute("isAnswer").Value.ToString() == "true")
                    trueAnswers.Add(rb.Text.ToLower());
                rb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                rb.Dock = DockStyle.None;
                rb.Width = gbAnswers.Width - 13;
                rb.AutoSize = false;
                rb.Location = new Point(x, y += 30);
                gbAnswers.Controls.Add(rb);
            }
        }

        private void GenCheck()
        {
            for (int i = 0; i < 4; i++)
            {
                XElement answer = question.Elements().ElementAt(RandomAnswers());
                CheckBox cb = new CheckBox();
                cb.Text = answer.Value;
                if (answer.Attribute("isAnswer").Value.ToString() == "true")
                    trueAnswers.Add(cb.Text.ToLower());
                cb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                cb.Dock = DockStyle.None;
                cb.AutoSize = false;
                cb.Width = gbAnswers.Width - 13;
                cb.Location = new Point(x, y += 30);
                gbAnswers.Controls.Add(cb);
            }
        }

        private void GenText()
        {
            TextBox tb = new TextBox();
            trueAnswers.Add(question.Element("answer").Value.ToLower());
            tb.Location = new Point(x, y += 30);
            tb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tb.Dock = DockStyle.None;
            tb.Width = gbAnswers.Width - 13;
            tb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            gbAnswers.Controls.Add(tb);
        }

        private void TypeCheck()
        {
            bool ask = false;
            foreach (CheckBox c in gbAnswers.Controls)
            {
                ask |= c.Checked;
            }
            if (ask || gbAnswers.Enabled == false)
            {
                int count = 0;
                foreach (CheckBox c in gbAnswers.Controls)
                {
                    if (c.Checked)
                    {
                        ask &= trueAnswers.Contains(c.Text.Trim().ToLower());
                        count++;
                    }
                }
                if (ask && count == trueAnswers.Count)
                    trueAsking++;
                notEmpty = true;
            }
            else
                lblScore.Text = "Выберите ответ";
        }

        private void TypeRadio()
        {
            bool ask = false;

            foreach (RadioButton r in gbAnswers.Controls)
            {
                ask |= r.Checked;
            }
            if (ask || gbAnswers.Enabled==false)
            {
                foreach (RadioButton r in gbAnswers.Controls)
                {
                    if (r.Checked)
                    {
                        ask = trueAnswers.Contains(r.Text.ToLower());
                        break;
                    }
                }
                if (ask)
                {
                    trueAsking++;
                }
                notEmpty = true;
            }
            else
                lblScore.Text = "Выберите ответ";
        }

        private void TypeText()
        {
            foreach (TextBox tb in gbAnswers.Controls)
            {
                if (tb.Text.Trim() == "" || gbAnswers.Enabled == false)
                    lblScore.Text = "Введите ответ";
                else
                {
                    if (trueAnswers.Contains(tb.Text.ToLower()))
                        trueAsking++;
                    notEmpty = true;
                }
            }

        }

        private void btnNextQue_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "radio":
                    TypeRadio();
                    break;
                case "check":
                    TypeCheck();
                    break;
                case "text":
                    TypeText();
                    break;
            }
            if (btnNextQue.Text == "Завершить попытку")
            {
                timer1.Stop();
                gbAnswers.Enabled = false;

                lblScore.Text = "Ваша оценка за прохождение теста: ";
                
                score = (trueAsking / 10.0) * 100;
                if (score >= 90)
                    score = 5;
                else if (score >= 75)
                    score = 4;
                else if (score >= 60)
                    score = 3;
                else
                    score = 2;
                lblScore.Text += (int)score;
                lblScore.Text += "\nКоличество правильных ответов: " + trueAsking;
                manager.menu.Enabled = true;
                if (currentUser.GetRole() != 3)
                {
                    usersDBDataSet.testingRow testingRow = usersDBDataSet1.testing.NewtestingRow();
                    testingRow.idUser = currentUser.GetId();
                    testingRow.nameOfTest = test;
                    testingRow.scoreOfTest = (short)score;
                    testingRow.dateOfTest = DateTime.Now;
                    usersDBDataSet1.testing.AddtestingRow(testingRow);
                    testingTableAdapter1.Update(testingRow);
                }
                btnNextQue.Enabled = false;
            }
            else
            {
                if (notEmpty || !timer1.Enabled)
                {
                    currentQusetion++;
                    GenQue();
                    notEmpty=false;
                }
                if (currentQusetion == 10)
                    btnNextQue.Text = "Завершить попытку";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waveTime != 0)
            {
                waveTime--;
                label1.Text = "Осталось " + waveTime / 10 + " сек";
                time.Value = waveTime;
            }
            else
            {
                lblScore.Text = "Время вышло! Перейдите к следующему вопросу";
                gbAnswers.Enabled = false;
            }
        }

        private void LoadTests()
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory + @"\tests");
            foreach (var file in dir.GetFiles())
            {
                lbTests.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                if (currentUser.GetRole() == 3)
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lbTests.SelectedIndex != -1)
            {
                manager.menu.Enabled = false;
                test = lbTests.SelectedItem.ToString();
                btnNextQue.Text = "Следующий вопрос";
                LoadTest();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnNextQue.Text != "Завершить попытку")
            {
                if (MessageBox.Show("Вы уверены что хотите вернуться к выбору теста?", "Вернуться к выбору теста", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StopTest();
                }
            }
            else
            {
                StopTest();
            }
        }

        private void StopTest()
        {
            manager.menu.Enabled = true;
            timer1.Stop();
            pnlTesting.Visible = false;
            currentQusetion = 1;
            trueAnswers.Clear();
            pnlTesting.Visible = false;
            pnlChooseTest.Visible = true;
            lbTests.SelectedIndex = -1;
            lblScore.Text = "";
        }
        private int CreateRandom()
        {
            int n;
            do
            {
                n = rndAnsw.Next(0, maxQuestion);
            }while (useQuestions.Contains(n)) ;
                useQuestions.Add(n);
            return n;
        }

        private void lbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTests.SelectedIndex != -1)
            {
                doc = XDocument.Load(Directory.GetCurrentDirectory() + @"\tests\" + lbTests.SelectedItem.ToString() + ".xml");
                root = doc.Element("test");
                maxQuestion = root.Elements().Count();
                label2.Text = "Критерии оценки:\n5-90% правильных ответов\n4-75% правильных ответов\n3-60% правильных ответов\nВсего вопросов: " + maxQuestion;
            }
        }

        private void Testing_SizeChanged(object sender, EventArgs e)
        {
            if (gbAnswers.Controls.Count!=0)
            {
                foreach (Control c in gbAnswers.Controls)
                    c.Width = gbAnswers.Width - 13;
            }
        }
    }
}
