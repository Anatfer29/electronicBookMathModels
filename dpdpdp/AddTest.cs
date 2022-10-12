using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace dpdpdp
{
    public partial class AddTest : Form
    {
        public static int currentQue = 0;
        public AddTest()
        {
            InitializeComponent();
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            cbType.SelectedIndex = 0;
            tbTest.Focus();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            answer2.Visible = true;
            answer3.Visible = true;
            answer4.Visible = true;

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            switch (cbType.SelectedIndex)
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
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (tbTest.Text != "")
            {
                if (tbQuestion.Text != "")
                {
                    if ((answer1.Text != "" && answer2.Text != "" && answer3.Text != "" && answer4.Text != "" && cbType.SelectedIndex != 2) || (answer1.Text != "" && cbType.SelectedIndex == 2))
                    {
                        if (checkAnswers())
                        {
                            if (currentQue == 0)
                            {
                                createXML();
                                manager.menu.Enabled = false;

                            }
                            else
                            {
                                saveQuestion();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Выберите вариант(ы) ответа");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите варианты ответа");
                    }
                }
                else
                {
                    MessageBox.Show("Введите название вопроса");
                }
            }
            else
            {
                MessageBox.Show("Введите наименование теста");
            }
        }

        private bool checkAnswers()
        {
            if (!(cb1.Checked | cb2.Checked | cb3.Checked | cb4.Checked) && cbType.SelectedIndex == 1)
                return false;
            if (!(rb1.Checked | rb2.Checked | rb3.Checked | rb4.Checked) && cbType.SelectedIndex == 0)
                return false;
            return true;
        }

        private void createXML()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\tests\" + tbTest.Text + ".xml"))
            {
                XmlDocument XmlDoc = new XmlDocument();
                XmlDeclaration XmlDec = XmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                XmlDoc.AppendChild(XmlDec);
                XmlElement ElementDatabase = XmlDoc.CreateElement("test");
                XmlDoc.AppendChild(ElementDatabase);
                XmlDoc.Save(Directory.GetCurrentDirectory() + @"\tests\" + tbTest.Text + ".xml");
                tbTest.Enabled = false;
                saveQuestion();
            }
            else
            {
                MessageBox.Show("Тест с таким именем уже есть");
            }
        }

        private void saveQuestion()
        {
            XDocument doc = XDocument.Load(Directory.GetCurrentDirectory() + @"\tests\" + tbTest.Text + ".xml");
            XElement root = doc.Element("test");

            XElement question = new XElement("question");
            XAttribute time = new XAttribute("time", numericUpDown1.Value);
            XAttribute text = new XAttribute("text", tbQuestion.Text);
            XAttribute type = new XAttribute("type", "");

            XAttribute isAnswer;
            string rbtrue = "";
            List<string> answerCb = new List<string>();
            currentQue++;

            if (cbType.SelectedIndex == 0)
            {
                type.Value = "radio";
                foreach (Control rb in gbAnswers.Controls)
                {
                    if (rb is RadioButton)
                    {
                        if (((RadioButton)rb).Checked)
                            rbtrue = rb.Name.Substring(rb.Name.Length - 1);
                    }
                }
                foreach (Control tb in gbAnswers.Controls)
                {
                    if (tb is TextBox)
                    {
                        XElement answer = new XElement("answer" + tb.Name[tb.Name.Length - 1], tb.Text.Trim());
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
                            answerCb.Add(cb.Name.Substring(cb.Name.Length - 1));
                    }
                }

                foreach (Control tb in gbAnswers.Controls)
                {
                    if (tb is TextBox)
                    {
                        XElement answer = new XElement("answer" + tb.Name[tb.Name.Length - 1], tb.Text.Trim());
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

            root.Add(question);
            doc.Save(Directory.GetCurrentDirectory() + @"\tests\" + tbTest.Text + ".xml");
            groupBox1.Text = "Вопрос " + (currentQue+1).ToString() + ": "; ;

            clearFields();
        }

        private void clearFields()
        {
            answer1.Clear();
            answer2.Clear();
            answer3.Clear();
            answer4.Clear();

            tbQuestion.Clear();

            cbType.SelectedIndex = 0;
        }

        private void CreateTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentQue < 10 && currentQue != 1)
            {
                if (MessageBox.Show("Минимальное количество вопросов-12. Вы уверены что хотите отменить добавление теста?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentQue < 10)
            {
                MessageBox.Show("Количество вопрос должно быть больше 9");
            }
            else
            {
                currentQue = 1;
                tbTest.Enabled = true;
                tbTest.Text = "";
                clearFields();
                cbType.SelectedIndex = 0;
                numericUpDown1.Value = 10;
                manager.menu.Enabled = true;
                MessageBox.Show("Тест успешно сохранён");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentQue > 1)
            {
                if (MessageBox.Show("Вы уверены что хотите отменить ввод тестирования", "Отмена добавления теста", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(Environment.CurrentDirectory + @"\tests\" + tbTest.Text + ".xml");
                    clearFields();
                    currentQue = 1;
                    tbTest.Text = "";
                    tbTest.Enabled = true;
                    manager.menu.Enabled = true;
                }
            }
        }
    }
}
