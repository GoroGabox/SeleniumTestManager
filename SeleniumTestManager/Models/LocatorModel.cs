using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestManager.Models
{
    public class LocatorModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CssSelector { get; set; }
        public string CssPath { get; set; }
        public string XmlPath { get; set; }
        public string HtmlTag { get; set; }
        public string CommonInteraction { get; set; }
        public string Value { get; set; }
    }
}
