using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Www;
using MbUnit.Framework;

namespace Www.Tests
{
    public class PageTests
    {
        [Test]
        public void TitleShouldBeNullIfNoTitleTag()
        {
            Page p = new Page("<html />");
            Assert.IsNull(p.Title);
        }

        [Test]
        public void TitleShouldBeSameAsTitleTag()
        {
            Page p = new Page("<html><head><title>Test Title</title></head></html>");
            Assert.AreEqual("Test Title", p.Title);
        }
    }
}
