using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace amazonAwsBot
{
    public partial class controlPanel : MetroFramework.Forms.MetroForm
    {
        string url = "https://eu-north-1.console.aws.amazon.com/ec2/v2/home?region=eu-north-1#Instances:sort=instanceId";

        string navBarID = "nav-regionMenu";
        string checkboxXpath = "//*[@id=\"gwt-debug-gridTable\"]/div[1]/div[3]/table/thead/tr/th[1]/div/div[1]/div/label/span/span";
        string actionsID = "gwt-debug-menuButton";
        string instanceStateID = "gwt-debug-menu-instance-state";
        string stopID = "gwt-debug-action-stop-instances";
        string yesStopID = "ActionDialogSubmitButtonId";
        string startID = "gwt-debug-action-start-instances";
        string yesStartID = "gwt-debug-dialogBoxSubmitButton-button";

        IWebDriver driver = new ChromeDriver();

        public controlPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startEC2_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl(url);

            try
            {
                IWebElement checkbox = driver.FindElement(By.XPath(checkboxXpath));
                checkbox.Click();

                IWebElement EC2Actions = driver.FindElement(By.Id(actionsID));
                EC2Actions.Click();

                IWebElement instances = driver.FindElement(By.Id(instanceStateID));
                Actions hover = new Actions(driver);
                hover.MoveToElement(instances).Perform();

                IWebElement start = driver.FindElement(By.Id(startID));
                start.Click();

                IWebElement yesStart = driver.FindElement(By.Id(yesStartID));
                start.Click();
            }
            catch(OpenQA.Selenium.NoSuchElementException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Log in to continue, or EC2 instances are already running", "OK");
            }
        }

        private void shutdownEC2_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl(url);

            try
            {
                IWebElement checkbox = driver.FindElement(By.XPath(checkboxXpath));
                checkbox.Click();

                IWebElement EC2Actions = driver.FindElement(By.Id(actionsID));
                EC2Actions.Click();

                IWebElement instances = driver.FindElement(By.Id(instanceStateID));
                Actions hover = new Actions(driver);
                hover.MoveToElement(instances).Perform();

                IWebElement stopButton = driver.FindElement(By.Id(stopID));
                stopButton.Click();

                IWebElement yesStop = driver.FindElement(By.Id(yesStopID));
                yesStop.Click();
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Log in to continue, or EC2 instances are already shut down", "OK");
            }
        }
    }
}
//Actions rightClick = new Actions(driver);              
//rightClick.ContextClick(EC2Actions).Build().Perform();   //right click