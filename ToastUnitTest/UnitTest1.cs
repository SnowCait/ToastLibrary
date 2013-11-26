using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using ToastLibrary;
using Windows.Data.Xml.Dom;

namespace ToastUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Text01()
        {
            Toast.Text01("txt");
        }

        [TestMethod]
        public void Text02()
        {
            Toast.Text02("head", "body");
        }

        [TestMethod]
        public void Text03()
        {
            Toast.Text03("head", "body");
        }

        [TestMethod]
        public void Text04()
        {
            Toast.Text04("head", "body1", "body2");
        }

        [TestMethod]
        public void ImageAndText01()
        {
            Toast.ImageAndText01("txt", "");
        }

        [TestMethod]
        public void ImageAndText02()
        {
            Toast.ImageAndText02("head", "body", "");
        }

        [TestMethod]
        public void ImageAndText03()
        {
            Toast.ImageAndText03("head", "body", "");
        }

        [TestMethod]
        public void ImageAndText04()
        {
            Toast.ImageAndText04("head", "body1", "body2", "");
        }
    }
}
