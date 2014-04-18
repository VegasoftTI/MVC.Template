﻿using NUnit.Framework;
using System.IO;
using System.Text;
using System.Web.Mvc;
using Template.Components.Extensions.Html;

namespace Template.Tests.Unit.Components.Extensions.Html
{
    [TestFixture]
    public class InputGroupTests
    {
        #region Constructor: InputGroup(TextWriter writer)

        [Test]
        public void InputGroup_WritesInputGroup()
        {
            var expected = new TagBuilder("div");
            expected.InnerHtml = "TestContent";
            expected.AddCssClass("input-group");

            var actual = new StringBuilder();
            var writer = new StringWriter(actual);
            var inputGroup = new InputGroup(writer);
            writer.Write("TestContent");
            inputGroup.Dispose();
            inputGroup.Dispose();

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        #endregion
    }
}