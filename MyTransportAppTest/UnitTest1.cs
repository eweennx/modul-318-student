using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTransportApp;

namespace MyTransportAppTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            TextBox textboxTest = new TextBox();
            textboxTest.Text = "Rothenbur";

            ListBox listboxTest = new ListBox();

            Vorschlaege.VorschlaegeFunction(textboxTest.Text, listboxTest);

            Assert.AreEqual("Rothenburg", listboxTest.Items[0].ToString());
        }
    }
}
