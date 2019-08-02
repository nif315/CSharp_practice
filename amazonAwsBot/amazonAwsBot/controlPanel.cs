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
        string urlSweden = "https://eu-north-1.console.aws.amazon.com/ec2/v2/home?region=eu-north-1#Instances:sort=instanceId";
        string urlParis = "https://eu-west-3.console.aws.amazon.com/ec2/v2/home?region=eu-west-3#Instances:sort=instanceId";
        string urlLondon = "https://eu-west-2.console.aws.amazon.com/ec2/v2/home?region=eu-west-2#Instances:sort=instanceId";
        string urlIreland = "https://eu-west-1.console.aws.amazon.com/ec2/v2/home?region=eu-west-1#Instances:sort=instanceId";
        string urlFrankfurt = "https://eu-central-1.console.aws.amazon.com/ec2/v2/home?region=eu-central-1#Instances:sort=instanceId";

        string navBarID = "nav-regionMenu";
        string checkboxXpath = "//*[@id=\"gwt-debug-gridTable\"]/div[1]/div[3]/table/thead/tr/th[1]/div/div[1]/div/label/span/span";
        string actionsID = "gwt-debug-menuButton";
        string instanceStateID = "gwt-debug-menu-instance-state";
        string stopID = "gwt-debug-action-stop-instances";
        string yesStopID = "ActionDialogSubmitButtonId";
        string startID = "gwt-debug-action-start-instances";
        string yesStartID = "gwt-debug-dialogBoxSubmitButton-button";

        private bool buttonRunClicked = false;
        private bool buttonShutDownClicked = false;

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
            buttonRunClicked = true;

            try
            {
                instancesActions();
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Log in to continue, or EC2 instances are already running", "OK");
            }

            buttonRunClicked = false;
        }

        private void shutdownEC2_Click(object sender, EventArgs e)
        {
            buttonShutDownClicked = true;

            try
            {
                instancesActions();
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Log in to continue, or EC2 instances are already shut down", "OK");
            }

            buttonShutDownClicked = false;
        }

        private void startInstances()
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
            yesStart.Click();
        }

        private void shutdownInstances()
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

        private void buttonStates()
        {
            if (buttonRunClicked)
                startInstances();

            if (buttonShutDownClicked)
                shutdownInstances();
        }

        private void instancesActions()
        {
            if (checkboxSweden.Checked)
            {
                driver.Navigate().GoToUrl(urlSweden);
                buttonStates();
            }

            if (checkboxParis.Checked)
            {
                driver.Navigate().GoToUrl(urlParis);
                buttonStates();
            }

            if (checkboxLondon.Checked)
            {
                driver.Navigate().GoToUrl(urlLondon);
                buttonStates();
            }

            if (checkboxIreland.Checked)
            {
                driver.Navigate().GoToUrl(urlIreland);
                buttonStates();
            }

            if (checkboxFrankfurt.Checked)
            {
                driver.Navigate().GoToUrl(urlFrankfurt);
                buttonStates();
            }
        }
    }
}
//Actions rightClick = new Actions(driver);              
//rightClick.ContextClick(EC2Actions).Build().Perform();   //right click