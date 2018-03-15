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
            button3.Enabled = true;
            login.Enabled = true;
            passoword.Enabled = true;
            

            //IWebElement SearchInput = Browser.FindElement(By.Id("lst-ib"));
            //SearchInput.SendKeys("Тест" + OpenQA.Selenium.Keys.Enter);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browser.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((login.Text.Equals("")) || (passoword.Text.Equals(""))) MessageBox.Show("Вы не ввели логин или пароль", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                IWebElement element;
                element = Browser.FindElement(By.LinkText("Войти"));
                element.Click();
                element = Browser.FindElement(By.Name("login"));
                element.SendKeys(login.Text);
                element = Browser.FindElement(By.Name("pass"));
                element.SendKeys(passoword.Text);
                element = Browser.FindElement(By.XPath("/html/body/div/div[1]/div[6]/form/div/span/span/input"));
                element.Click();
                timeout_count.Enabled = true;
                Arana.Enabled = true;
                Arena_count.Enabled = true;
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void passoword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Arana_Click(object sender, EventArgs e)
        {
            IWebElement element;
            //element = Browser.FindElement(By.LinkText("Арена"));
            element = Browser.FindElement(By.PartialLinkText("Арена"));
            element.Click();
            int count = Convert.ToInt32(Arena_count.Text);
            int timeout = Convert.ToInt32(timeout_count.Text);
            for (int i = 0; i < count; i++)
            {
                //element = Browser.FindElement(By.ClassName("label"));
                element = Browser.FindElement(By.ClassName("p_dummy"));
                element.Click();
                System.Threading.Thread.Sleep(timeout);
            }
            element = Browser.FindElement(By.LinkText("На главную"));
            element.Click();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
