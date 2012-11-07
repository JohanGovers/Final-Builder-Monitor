using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FinalBuilderMonitor;
using System.IO;

namespace FinalBuilderMonitor.Test
{
    [TestFixture]
    public class MainVMTests
    {
        [Test]
        public void TestCrawlerTowardsGithubJohanGovers()
        {
            var html = new MainVM().GetPageContent("https://github.com/JohanGovers");

            Assert.IsTrue(html.Contains("github.com"));
        }
    }
}
