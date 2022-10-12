using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace dpdpdp
{
    public partial class EditTest : Form
    {
        XDocument doc;
        string test;
        XElement root;
        bool add = false;
        XElement question;
        string typeQ;
        bool adding = false;
        public static int currentQue = 0;
        int selIndex = 0;

        public EditTest()
        {
            InitializeComponent();
            LoadTests();
        }
        private void LoadTests()
        {
            lbTests.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory + @"\tests");
            foreach (var file in dir.GetFiles())
            {
                lbTests.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }

        private void LoadTest()
        {
            lblMess.Text = "";
            cbType.SelectedIndex = 0;
            lbQuestions.Items.Clear();
            tbNameOfTest.Text = "";
            if (adding)
            {
                groupBox1.Text = "Вопрос 1";
                doc = new XDocument();
                root = new XElement("test");
                doc.Add(root);
            }
            else
            {
                pnlQuestions.Visible = true;
                doc = XDocument.Load(Directory.GetCurrentDirectory() + @"\tests\" + test + ".xml");
                root = doc.Element("test");
                for (int i = 0; i < root.Elements().Count(); i++)
                    lbQuestions.Items.Add("Вопрос " + (i + 1));
                lbQuestions.SelectedIndex = selIndex;
            }
        }

        private void lbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQuestions.SelectedIndex != -1)
            {
                selIndex = lbQuestions.SelectedIndex;
                lblInfo.Text = "";
                lblEdit.Text = "Изменение " + (lbQuestions.SelectedIndex + 1) + " вопроса";
                add = false;
                groupBox1.Text = "Вопрос " + (lbQuestions.SelectedIndex + 1);
                question = root.Elements().ElementAt(lbQuestions.SelectedIndex);
                tbQuestion.Text = question.Attribute("text").Value;
                numericUpDown1.Value = Convert.ToInt32(question.Attribute("time").Value);
                typeQ = question.Attribute("type").Value;
                int i = 0;
                switch (question.Attribute("type").Value)
                {
                    case "text":
                        cbType.SelectedIndex = 2;
                        TakeAnswer(2);
                        answer1.Text = question.Element("answer").Value;
                        break;
                    case "radio":
                        cbType.SelectedIndex = 0;
                        TakeAnswer(0);
                        i = 0;
                        foreach (Control c in gbAnswers.Controls)
                        {
                            if (c is TextBox)
                            {
                                XElement answer = question.Elements().ElementAt(i);
                                c.Text = answer.Value;
                                if (answer.Attribute("isAnswer").Value == "true")
                                {
                                    ((RadioButton)gbAnswers.Controls.Find("rb" + c.Name.Substring(c.Name.Length - 1), false).First()).Checked = true;
                                }
                                i++;
                            }
                        }
                        break;
                    case "check":
                        TakeAnswer(1);
                        i = 0;
                        cbType.SelectedIndex = 1;
                        foreach (Control c in gbAnswers.Controls)
                        {
                            if (c is TextBox)
                            {
                                XElement answer = question.Elements().ElementAt(i);
                                c.Text = answer.Value;
                                if (answer.Attribute("isAnswer").Value == "true")
                                {
                                    ((CheckBox)gbAnswers.Controls.Find("cb" + c.Name.Substring(c.Name.Length - 1), false).First()).Checked = true;
                                }
                                i++;
                            }
                        }
                        break;
                }
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex != -1)
                TakeAnswer(cbType.SelectedIndex);
        }

        private void TakeAnswer(int index)
        {
            answer2.Visible = true;
            answer3.Visible = true;
            answer4.Visible = true;

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            switch (index)
            {
                case 0:
                    cb1.Checked = cb1.Visible = false;
                    cb2.Checked = cb2.Visible = false;
                    cb3.Checked = cb3.Visible = false;
                    cb4.Checked = cb4.Visible = false;

                    rb1.Visible = true;
                    rb2.Visible = true;
                    rb3.Visible = true;
                    rb4.Visible = true;
                    typeQ = "radio";
                    break;
                case 1:
                    rb1.Checked = rb1.Visible = false;
                    rb2.Checked = rb2.Visible = false;
                    rb3.Checked = rb3.Visible = false;
                    rb4.Checked = rb4.Visible = false;

                    cb1.Visible = true;
                    cb2.Visible = true;
                    cb3.Visible = true;
                    cb4.Visible = true;
                    typeQ = "check";
                    break;
                case 2:
                    answer2.Visible = false;
                    answer3.Visible = false;
                    answer4.Visible = false;

                    rb1.Checked = rb1.Visible = false;
                    rb2.Checked = rb2.Visible = false;
                    rb3.Checked = rb3.Visible = false;
                    rb4.Checked = rb4.Visible = false;

                    cb1.Checked = cb1.Visible = false;
                    cb2.Checked = cb2.Visible = false;
                    cb3.Checked = cb3.Visible = false;
                    cb4.Checked = cb4.Visible = false;

                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    typeQ = "text";
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEdit.Text = "Добавление нового вопроса";
            groupBox1.Text = "Добавление вопроса";
            lbQuestions.SelectedIndex = -1;
            add = true;
            lblInfo.Text = "";
            tbNameOfTest.Text = "";
            clearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbQuestions.SelectedIndex != -1)
            {
                if (lbQuestions.Items.Count > 10)
                {
                    root.Elements().ElementAt(lbQuestions.SelectedIndex).Remove();
                    doc.Save(Directory.GetCurrentDirectory() + @"\tests\" + test + ".xml");
                    lbQuestions.Items.Clear();
                    for (int i = 0; i < root.Elements().Count(); i++)
                        lbQuestions.Items.Add("Вопрос " + (i + 1));
                    clearFields();
                    add = true;
                    lblEdit.Text = "Добавление нового вопроса";
                    groupBox1.Text = "Добавление вопроса";
                    lblInfo.Text = "Вопрос успешно удален";
                }
                else
                    lblInfo.Text = "Минимальное количество вопросов - 10";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (adding)
            {
                if (currentQue < 10)
                {
                    lblInfo.Text = "Количество вопрос должно быть больше 9";
                }
                else
                {
                    if (tbNameOfTest.Text.Trim() == "")
                    {
                        lblInfo.Text = "Введите наименование теста";
                        
                    }
                    else
                    {
                        if (File.Exists(Environment.CurrentDirectory + @"\tests\" + tbNameOfTest.Text + ".xml"))
                        {
                            lblInfo.Text = "Наименование теста уже занято";
                        }
                        else
                        {
                            SaveTest();
                            currentQue = 0;
                            tbNameOfTest.Text = "";
                            clearFields();
                            cbType.SelectedIndex = 0;
                            numericUpDown1.Value = 10;
                            manager.menu.Enabled = true;
                            lblInfo.Text = "Тест успешно сохранён";
                            groupBox1.Text = "Вопрос 1";
                        }
                    }
                }
            }
            else
            {
                if (tbQuestion.Text.Trim() != "")
                {
                    if (((answer1.Text.Trim() != "" && answer2.Text.Trim() != "" && answer3.Text.Trim() != "" && answer4.Text.Trim() != "" && cbType.SelectedIndex != 2) || (answer1.Text.Trim() != "" && cbType.SelectedIndex == 2)))
                    {
                        if (checkAnswers())
                        {
                            if (!add)
                            {
                                question.RemoveNodes();
                                question.RemoveAttributes();
                                SaveQuestion();
                                lblInfo.Text = "Вопрос успешно изменён";
                            }
                            else
                            {
                                question = new XElement("question");
                                SaveQuestion();
                                add = false;
                                lblInfo.Text = "Вопрос успешно добавлен";
                            }
                        }
                        else
                            lblInfo.Text = "Выберите правильные ответы";
                    }
                    else
                        lblInfo.Text = "Введите варианты ответов";
                }
                else
                    lblInfo.Text = "Введите наименование вопроса";
            }
        }

        private void clearFields()
        {
            answer1.Clear();
            answer2.Clear();
            answer3.Clear();
            answer4.Clear();

            lblInfo.Text = "";

            numericUpDown1.Value = 20;

            tbQuestion.Clear();

            cbType.SelectedIndex = 0;
            foreach (Control c in gbAnswers.Controls)
            {
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                else if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
            }
        }

        private bool checkAnswers()
        {
            if ((!(cb1.Checked | cb2.Checked | cb3.Checked | cb4.Checked) && cbType.SelectedIndex == 1) || (!(rb1.Checked | rb2.Checked | rb3.Checked | rb4.Checked) && cbType.SelectedIndex == 0))
            {
                lblInfo.Text = "Выберите правильный ответ";
                return false;
            }
            return true;
        }

        private void SaveQuestion()
        {
            XAttribute time = new XAttribute("time", numericUpDown1.Value);
            XAttribute text = new XAttribute("text", tbQuestion.Text);
            XAttribute type = new XAttribute("type", typeQ);

            if (adding)
                question = new XElement("question");

            XAttribute isAnswer;
            string rbtrue = "";
            List<string> answerCb = new List<string>();

            if (cbType.SelectedIndex == 0)
            {
                type.Value = "radio";
                foreach (Control rb in gbAnswers.Controls)
                {
                    if (rb is RadioButton)
                    {
                        if (((RadioButton)rb).Checked)
                        {
                            rbtrue = rb.Name.Trim().Substring(rb.Name.Length - 1);
                            break;
                        }
                    }
                }
                foreach (Control tb in gbAnswers.Controls)
                {
                    if (tb is TextBox)
                    {
                        XElement answer = new XElement("answer", tb.Text.Trim());
                        isAnswer = new XAttribute("isAnswer", tb.Name.Substring(tb.Name.Length - 1) == rbtrue ? true : false);
                        answer.Add(isAnswer);
                        question.Add(answer);
                    }
                }
            }
            else if (cbType.SelectedIndex == 1)
            {
                type.Value = "check";
                foreach (Control cb in gbAnswers.Controls)
                {
                    if (cb is CheckBox)
                    {
                        if (((CheckBox)cb).Checked)
                            answerCb.Add(cb.Name.Trim().Substring(cb.Name.Length - 1));
                    }
                }

                foreach (Control tb in gbAnswers.Controls)
                {
                    if (tb is TextBox)
                    {
                        XElement answer = new XElement("answer", tb.Text.Trim());
                        isAnswer = new XAttribute("isAnswer", answerCb.Contains(tb.Name.Substring(tb.Name.Length - 1)) ? true : false);
                        answer.Add(isAnswer);
                        question.Add(answer);
                    }
                }
            }
            else
            {
                XElement answer = new XElement("answer", answer1.Text.Trim());
                type.Value = "text";
                question.Add(answer);
            }

            question.Add(time);
            question.Add(text);
            question.Add(type);
            if (add && !adding)
            {
                root.Add(question);
                doc.Save(Directory.GetCurrentDirectory() + @"\tests\" + test + ".xml");
            }
            else if (adding)
            {
                root.Add(question);
            }
            else
            {
                root.Elements().ElementAt(lbQuestions.SelectedIndex).ReplaceAll(question.Attributes(), question.Elements());
                doc.Save(Directory.GetCurrentDirectory() + @"\tests\" + test + ".xml");
            }
            clearFields();
            lbQuestions.SelectedIndex = -1;
            add = true;
            lblEdit.Text = "Добавление нового вопроса";
            groupBox1.Text = "Добавление вопроса";
            if (!adding)
                LoadTest();
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            if (lbTests.SelectedIndex != -1)
            {
                pnlChooseTest.Visible = false;
                pnlEditTest.Visible = true;
                pnlEditTest.Dock = DockStyle.Fill;
                test = lbTests.SelectedItem.ToString();
                btnNextQue.Visible = false;
                LoadTest();
                tbNameOfTest.Text = test;
                lbQuestions.SelectedIndex = 0;
            }
            else
            {
                lblMess.Text = "Выберите тест для изменения";
            }
        }

        private void SaveTest()
        {
            doc.Declaration = new XDeclaration("1.0", "utf-8", "yes");
            if (test!="")
            {
                File.Delete(Environment.CurrentDirectory + @"\tests\" + test + ".xml");
            }
            doc.Save(Environment.CurrentDirectory + @"\tests\" + (tbNameOfTest.Text.Trim()==""?test:tbNameOfTest.Text.Trim()) + ".xml");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (adding)
            {
                if (currentQue < 10 && currentQue != 0)
                {
                    if (MessageBox.Show("Минимальное количество вопросов для добавления-10. Вы уверены что хотите отменить добавление теста?", "Добавление теста", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        pnlEditTest.Visible = false;
                        pnlChooseTest.Visible = true;
                        manager.menu.Enabled = true;
                        adding = false;
                        add = false;
                        currentQue = 0;
                    }
                }
                else
                {
                    if (currentQue >= 10)
                    {
                        if (!File.Exists(Environment.CurrentDirectory + @"\tests\" + tbNameOfTest.Text + ".xml"))
                        {
                            if (MessageBox.Show("Вы не сохранили созданный тест. Вы уверены что хотите вернуться к выбору тестов?", "Сохранение теста", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                LoadTests();
                                adding = false;
                                clearFields();
                                pnlEditTest.Visible = false;
                                pnlChooseTest.Visible = true;
                                manager.menu.Enabled = true;
                                add = false;
                                currentQue = 0;
                            }
                        }
                    }
                    else
                    { 
                        LoadTests();
                        adding = false;
                        clearFields();
                        pnlEditTest.Visible = false;
                        pnlChooseTest.Visible = true;
                        manager.menu.Enabled = true;
                        add = false;
                    }
                }
            }
            else
            {
             //   File.Delete(Environment.CurrentDirectory + @"\tests\" + test + ".xml");
                pnlEditTest.Visible = false;
                pnlChooseTest.Visible = true;
                SaveTest();
                clearFields();
                add = false;
                LoadTests();
            }
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            lblMess.Text = "";
            lblEdit.Text = "Добавление нового вопроса";
            add = true;
            adding = true;
            btnNextQue.Visible = true;
            LoadTest();
            manager.menu.Enabled = false;
            pnlChooseTest.Visible = false;
            pnlEditTest.Visible = true;
            pnlEditTest.Dock = DockStyle.Fill;
            pnlQuestions.Visible = false;
        }

        private void btnNextQue_Click(object sender, EventArgs e)
        {
            if (tbNameOfTest.Enabled)
            {
                if (tbQuestion.Text.Trim() != "")
                {
                    if ((answer1.Text.Trim() != "" && answer2.Text.Trim() != "" && answer3.Text.Trim() != "" && answer4.Text.Trim() != "" && cbType.SelectedIndex != 2) || (answer1.Text.Trim() != "" && cbType.SelectedIndex == 2))
                    {
                        if (checkAnswers())
                        {
                            SaveQuestion();
                            clearFields();
                            currentQue++;
                            groupBox1.Text = "Вопрос " + (currentQue + 1);
                        }
                        else
                            lblInfo.Text = "Выберите правильные ответы";
                    }
                    else
                        lblInfo.Text = "Введите варианты ответов";
                }
                else
                    lblInfo.Text = "Заполните наименование вопроса";
            }
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            if (lbTests.SelectedIndex!=-1)
            {
                File.Delete(Environment.CurrentDirectory + @"\tests\" + lbTests.SelectedItem.ToString() + ".xml");
                lblMess.Text = "Выбранный тест успешно удалён";
                LoadTests();
            }
            else
            {
                lblMess.Text = "Выберите тест для удаления";
            }
        }
    }
}
