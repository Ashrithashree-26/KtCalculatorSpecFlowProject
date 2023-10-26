using NUnit.Framework;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace KtCalculatorSpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorOperationStepDefinitions
    {

        private Window _calculatorWindow;
        private Application _calculatorApp;
        private Button _button;

       
        [Given(@"i close all instances")]
        public void GivenICloseAllInstances()
        {
           // var processes = Process.GetProcessesByName("calc1");
            //foreach (var process in processes)
            {
               // process.CloseMainWindow();
            }
        }


        [When(@"i open calculator")]
        public void WhenIOpenCalculator()
        {
            string Path = $"C:\\Program Files\\OldClassicCalc\\calc1.exe";
            //var CalculatorPath1 = Path.Combine(C:\Users\conspol\Downloads\oldcalcWin11Win10, "OldClassicCalc-2.0-setup.exe");
            _calculatorApp = Application.Launch(Path);

            // Window CalculatorWindow = CalculatorApp.GetWindow("CalculatorApp");
            _calculatorWindow = _calculatorApp.GetWindow("Calculator", InitializeOption.NoCache);
        }

        [When(@"i perform some addition operation")]
        public void WhenIPerformSomeAdditionOperation()
        {
            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("131"));
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("132"));
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("93"));
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("139"));
            _button.Click();
            _button.Click();
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("121"));
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("125"));
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("93"));
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("131"));
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("139"));
            _button.Click();

            _button = _calculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("121"));
            _button.Click();
        }

        [Then(@"i should get the result")]
        public void ThenIShouldGetTheResult()
        {
            //Label resultLabel = _calculatorWindow.Get<Label>("ResultLabel");
            //string actualResultText = resultLabel.Text;
            //int actualResult = int.Parse(actualResultText);


            //Assert.AreEqual(1030, actualResult);
        }

    }
}