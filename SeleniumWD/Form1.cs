using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace SeleniumWD
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;

        List<IWebElement> bFilters;

        List<List<IWebElement>> sources = new List<List<IWebElement>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void KeyWord_TextChanged(object sender, EventArgs e)
        {
            IWebElement keyWordInput = Browser.FindElement(By.Name("query"));
            keyWordInput.Clear();
            keyWordInput.SendKeys(KeyWord.Text);
        }

        private void DepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bFilters[0].Click();
            IWebElement selectedDepartment = sources[0][DepartmentFilter.SelectedIndex];
            selectedDepartment.Click();
        }

        private void LanguageFilter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bFilters[1].Click();
            IWebElement selectedLanguage = sources[1][LanguagesFilter.SelectedIndex];
            selectedLanguage.Click();
            bFilters[1].Click();
        }

        private void ExperienceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bFilters[2].Click();
            IWebElement selectedExperience = sources[2][ExperienceFilter.SelectedIndex];
            selectedExperience.Click();
        }

        private void RegionFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bFilters[3].Click();
            IWebElement selectedRegion = sources[3][RegionFilter.SelectedIndex];
            selectedRegion.Click();
        }

        private void NumberVacancies_Click(object sender, EventArgs e)
        {
            List<IWebElement> vacancies = Browser.FindElements(By.ClassName("card-no-hover")).ToList();
            dNumberVacancies.Text = vacancies.Count.ToString();
        }

        private void OpenBrowser_Click(object sender, EventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://careers.veeam.ru/vacancies");

            KeyWord.ReadOnly = false;
            DepartmentFilter.Enabled = true;
            LanguagesFilter.Enabled = true;
            ExperienceFilter.Enabled = true;
            RegionFilter.Enabled = true;
            NumberVacancies.Enabled = true;

            GetSources();
        }

        private void CloseBrowser_Click(object sender, EventArgs e)
        {
            if (Browser != null)
            {
                KeyWord.ReadOnly = true;
                DepartmentFilter.Enabled = false;
                LanguagesFilter.Enabled = false;
                ExperienceFilter.Enabled = false;
                RegionFilter.Enabled = false;
                NumberVacancies.Enabled = false;

                ClearSources();

                Browser.Quit();
            }
        }

        private void GetSources()
        {
            /*IWebElement bDepartmentFilter = Browser.FindElement(By.XPath("//*[text()='Все отделы']"));*/

            object[] objectsForm = { DepartmentFilter, LanguagesFilter, ExperienceFilter, RegionFilter };
            bFilters = Browser.FindElements(By.Id("sl")).ToList();
            int itterator = 0;
            foreach (IWebElement bFilter in bFilters)
            {
                bFilter.Click();
                bFilter.Click();

                List<IWebElement> sourceLinks = bFilter.FindElement(By.XPath("./parent::*"))
                    .FindElements(By.CssSelector(itterator != 1 ? "a:not([class*='disabled'])" : "label")).ToList();
                //List<IWebElement> sourceLinks = bFilter.FindElement(By.XPath("./parent::*")).FindElements(By.TagName(itterator != 1 ? "a" : "label")).ToList();
                sources.Add(sourceLinks);

                foreach (IWebElement source in sourceLinks)
                {
                    if (itterator == 1)
                    {
                        ((CheckedListBox)objectsForm[itterator]).Items.Add(source.GetAttribute("innerHTML"));
                    }
                    else
                    {
                        ((ComboBox)objectsForm[itterator]).Items.Add(source.GetAttribute("innerHTML"));
                        ((ComboBox)objectsForm[itterator]).SelectedIndex = 0;

                    }
                }
                itterator++;
            }
            DepartmentFilter.SelectedIndexChanged += new EventHandler(DepartmentFilter_SelectedIndexChanged);
            ExperienceFilter.SelectedIndexChanged += new EventHandler(ExperienceFilter_SelectedIndexChanged);
            RegionFilter.SelectedIndexChanged += new EventHandler(RegionFilter_SelectedIndexChanged);
        }

        private void ClearSources()
        {
            DepartmentFilter.Items.Clear();
            DepartmentFilter.ResetText();

            LanguagesFilter.Items.Clear();
            LanguagesFilter.ResetText();

            ExperienceFilter.Items.Clear();
            ExperienceFilter.ResetText();

            RegionFilter.Items.Clear();
            RegionFilter.ResetText();

            dNumberVacancies.Text = "";
        }
    }
}
