
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

using NUnit.Framework;

namespace LeraFormTest
{

    public class PrettyInterfaceTests
    {
        TestStack.White.Application leraApp;
        Window mainWindow;
        //Application leraApp = new Application(@"./LeraCute/bin/Debug/LeraCute.exe");

        TestStack.White.UIItems.Button btn;
        TestStack.White.UIItems.Label label;

        [TestFixtureSetUp]
        public void SetUp()
        {
            //leraApp = TestStack.White.Application.Launch(@"D:\MyProgramFiles\Git\LeraCuteProj\LeraForm\bin\Debug\LeraForm.exe");
            leraApp = TestStack.White.Application.Launch("LeraForm.exe");
            //mainWindow = leraApp.GetWindow(SearchCriteria.ByAutomationId("MainWindow"), TestStack.White.Factory.InitializeOption.WithCache);
            mainWindow = leraApp.GetWindow("myWin");
            btn =
               mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByAutomationId("button1"));
            label =
              mainWindow.Get<TestStack.White.UIItems.Label>(SearchCriteria.ByAutomationId("label1"));

        }

        [Test]
        public void Test1()
        {
            btn.Click();
            Assert.AreEqual("awww", label.Text.ToString());
            mainWindow.Close();
        }
    }
}
