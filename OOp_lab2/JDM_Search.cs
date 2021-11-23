using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace OOp_lab2
{
    public partial class JDM_Search : Form
    {
        string path = "JDM.xml";
        List<JDM> final = new List<JDM>();
        public JDM_Search()
        {
            InitializeComponent();
        }
        public void FillBox()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("JDM.xml");
            XmlNodeList elem = doc.SelectNodes("//drive_unit");
            foreach(XmlNode e in elem)
            {
                XmlNodeList list1 = e.ChildNodes;
                foreach(XmlNode el in list1)
                {
                    string drive_unit = el.ParentNode.Attributes.GetNamedItem("DRIVE_UNIT").Value;
                    if (!comboBox1.Items.Contains(drive_unit))
                        comboBox1.Items.Add(drive_unit);
                    string brand = el.Attributes.GetNamedItem("BRAND").Value;
                    if (!comboBox2.Items.Contains(brand))
                        comboBox2.Items.Add(brand);
                    string model = el.Attributes.GetNamedItem("MODEL").Value;
                    if (!comboBox3.Items.Contains(model))
                        comboBox3.Items.Add(model);
                    string engine = el.Attributes.GetNamedItem("ENGINE").Value;
                    if (!comboBox4.Items.Contains(engine))
                        comboBox4.Items.Add(engine);
                    string year = el.Attributes.GetNamedItem("YEAR").Value;
                    if (!comboBox5.Items.Contains(year))
                        comboBox5.Items.Add(year);
                    string max_speed = el.Attributes.GetNamedItem("MAX_SPEED").Value;
                    if (!comboBox6.Items.Contains(max_speed))
                        comboBox6.Items.Add(max_speed);
                    string price = el.Attributes.GetNamedItem("PRICE").Value;
                    if (!comboBox7.Items.Contains(price))
                        comboBox7.Items.Add(price);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            DriveUnit.Checked = false;
            Brand.Checked = false;
            Model.Checked = false;
            Engine.Checked = false;
            Year.Checked = false;
            MaxSpeed.Checked = false;
            Price.Checked = false;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            LINQ.Checked = false;
            DOM.Checked = false;
            SAX.Checked = false;
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("XSL.xsl");
            string input = @"JDM.xml";
            string result = @"info.html";

            xslt.Transform(input, result);
            MessageBox.Show("Success!");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            JDM _car = MyJDM();
            if (LINQ.Checked)
            {
                IStrategy CurrentStrategy = new LINQ(path);
                final = CurrentStrategy.Algorithm(_car, path);
                Output(final);
            }
            if (DOM.Checked)
            {
                IStrategy CurrentStrategy = new DOM(path);
                final = CurrentStrategy.Algorithm(_car, path);
                Output(final);
            }
            if (SAX.Checked)
            {
                IStrategy CurrentStrategy = new SAX(path);
                final = CurrentStrategy.Algorithm(_car, path);
                Output(final);
            }
            else
            {
                IStrategy CurrentStrategy = new LINQ(path);
                final = CurrentStrategy.Algorithm(_car, path);
                Output(final);
            }
        }

        private JDM MyJDM()
        {
            string[] info = new string[7];
            if (DriveUnit.Checked) info[0] = Convert.ToString(comboBox1.Text);
            if (Brand.Checked) info[1] = Convert.ToString(comboBox2.Text);
            if (Model.Checked) info[2] = Convert.ToString(comboBox3.Text);
            if (Engine.Checked) info[3] = Convert.ToString(comboBox4.Text);
            if (Year.Checked) info[4] = Convert.ToString(comboBox5.Text);
            if (MaxSpeed.Checked) info[5] = Convert.ToString(comboBox6.Text);
            if (Price.Checked) info[6] = Convert.ToString(comboBox7.Text);
            JDM perfectJDM = new JDM(info);
            return perfectJDM;
        }

        private void Output(List<JDM> final)
        {
            richTextBox1.Clear();
            if (final.Count == 0)
            {
                richTextBox1.AppendText("Nothing was found! \n");
                return;
            }
            int i = 1;
            foreach (JDM n in final)
            {
                richTextBox1.AppendText(i++ + "." + "\n");
                richTextBox1.AppendText("Drive Unit: " + n.Drive_unit + "\n");
                richTextBox1.AppendText("Brand: " + n.Brand + "\n");
                richTextBox1.AppendText("Model: " + n.Model + "\n");
                richTextBox1.AppendText("Engine: " + n.Engine + "\n");
                richTextBox1.AppendText("Year: " + n.Year + "\n");
                richTextBox1.AppendText("Max Speed: " + n.Max_speed + "\n");
                richTextBox1.AppendText("Price: " + n.Price + "\n");
                richTextBox1.AppendText("____________________________________" + "\n");
            }
        }

        private void JDM_Search_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FillBox();
        }

        private void JDM_Search_FormClosing(object sender, FormClosingEventArgs e)
        {
                DialogResult userAnswer = MessageBox.Show("Ви точно бажаєте закрити додаток?", "Закрити додаток?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (userAnswer == DialogResult.Yes)
                    this.Dispose();
                else if (userAnswer == DialogResult.No)
                    e.Cancel = true;
        }
    }
}
