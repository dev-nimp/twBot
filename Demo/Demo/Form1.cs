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

namespace Demo
{
    public partial class Form1 : Form
    {

        IWebDriver Browser;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("http://tiwar.ru");

            //IWebElement SearchInput = Browser.FindElement(By.Id("lst-ib"));
            //SearchInput.SendKeys("Тест" + OpenQA.Selenium.Keys.Enter);

            IWebElement element;
            element = Browser.FindElement(By.LinkText("Войти"));
            element.Click();
            element = Browser.FindElement(By.Name("login"));
            element.SendKeys("*");
            element = Browser.FindElement(By.Name("pass"));
            element.SendKeys("*");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browser.Quit();
        }
    }
}
