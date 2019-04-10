using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MaterialSkin;
using MaterialSkin.Controls;


namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML file (*.xml)|*.xml";
            sfd.Title = "Save XML file";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, xmlOutput.Text);
            }
            else
            {
                MessageBox.Show("You have not chosen a flie");
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            JsonInput.Clear();
            xmlOutput.Clear();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON file (*.json)|*.json";
            ofd.Title = "Open JSON file";

            if (ofd.ShowDialog()==DialogResult.OK)
            {
                JsonInput.Text = File.ReadAllText(ofd.FileName);
            }
            else
            {
                MessageBox.Show("You have not chosen a flie");
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            xmlOutput.Clear();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            JsonInput.Clear();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int countJopen = 0;
            foreach (Match m in Regex.Matches(JsonInput.Text, "{"))
                countJopen++;
            int countJclosing = 0;
            foreach (Match m in Regex.Matches(JsonInput.Text, "}"))
                countJclosing++;

            if (string.IsNullOrWhiteSpace(JsonInput.Text))
            {
                MessageBox.Show("Input JSON code");
            }
            else if (countJopen < countJclosing)
            {
                MessageBox.Show("Opening bracket '{' is missing");
            }
            else if (countJopen > countJclosing)
            {
                MessageBox.Show("Closing bracket '}' is missing");
            }
            else
            {
                try
                {
                    string json = JsonInput.Text;
                    XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json);
                    xmlOutput.Text = doc.InnerXml;
                }
                catch (Newtonsoft.Json.JsonReaderException)
                {
                    MessageBox.Show("JSON syntax error");
                }
            }
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            jsonOutput.Clear();
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            xmlInput.Clear();
            jsonOutput.Clear();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            xmlInput.Clear();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.Filter = "JSON file (*.json)|*.json";
            sfd1.Title = "Save JSON file";

            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd1.FileName, jsonOutput.Text);
            }
            else
            {
                MessageBox.Show("You have not chosen a flie");
            }
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "XML file (*.xml)|*.xml";
            ofd1.Title = "Open XML file";

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                xmlInput.Text = File.ReadAllText(ofd1.FileName);
            }
            else
            {
                MessageBox.Show("You have not chosen a flie");
            }
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            {
                int countXopen = 0;
                foreach (Match m in Regex.Matches(xmlInput.Text, "<"))
                    countXopen++;
                int countXclosing = 0;
                foreach (Match m in Regex.Matches(xmlInput.Text, ">"))
                    countXclosing++;

                if (string.IsNullOrWhiteSpace(xmlInput.Text))
                {
                    MessageBox.Show("Input XML code");
                }
                else if (countXopen < countXclosing)
                {
                    MessageBox.Show("Opening bracket '<' is missing");
                }
                else if (countXopen > countXclosing)
                {
                    MessageBox.Show("Closing bracket '>' is missing");
                }
                else
                {
                    try
                    {
                        string xml = xmlInput.Text;
                        XmlDocument xdoc = new XmlDocument();
                        xdoc.LoadXml(xml);
                        string jsontext = JsonConvert.SerializeXmlNode(xdoc);
                        jsonOutput.Text = jsontext;
                    }
                    catch (System.Xml.XmlException)
                    {
                        MessageBox.Show("XML syntax error");
                    }
                }
            }
        }
    }
}
