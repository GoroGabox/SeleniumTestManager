using ClosedXML.Excel;
using OpenQA.Selenium;
using SeleniumTestManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestManager.Locators
{
    public static class LocatorReader
    {
        public static Dictionary<string, By> LoadLocators(string excelFilePath, string sheetName, string locatorType)
        {
            var locators = new Dictionary<string, By>();

            using (var workbook = new XLWorkbook(excelFilePath))
            {
                var worksheet = workbook.Worksheet(sheetName);
                var rows = worksheet.RowsUsed().Skip(1); // Asumiendo que la primera fila es el encabezado

                foreach (var row in rows)
                {
                    var model = new LocatorModel
                    {
                        Id = row.Cell(1).GetValue<string>(),
                        Name = row.Cell(2).GetValue<string>(),
                        CssSelector = row.Cell(3).GetValue<string>(),
                        CssPath = row.Cell(4).GetValue<string>(),
                        XmlPath = row.Cell(5).GetValue<string>(),
                        HtmlTag = row.Cell(6).GetValue<string>(),
                        CommonInteraction = row.Cell(7).GetValue<string>(),
                        Value = row.Cell(8).GetValue<string>()
                    };

                    By locator = locatorType.ToLower() switch
                    {
                        "id" => By.Id(model.Id),
                        "name" => By.Name(model.Name),
                        "cssselector" => By.CssSelector(model.CssSelector),
                        "csspath" => By.CssSelector(model.CssPath),
                        "xmlpath" => By.XPath(model.XmlPath),
                        _ => throw new ArgumentException("Invalid locator type specified.")
                    };

                    locators.Add(model.Name, locator);
                }
            }

            return locators;
        }
    }

    public static class LoginPageLocatorsExcel
    {
        public static Dictionary<string, By> GetLocators(string excelFilePath, string sheetName, string locatorType)
        {
            return LocatorReader.LoadLocators(excelFilePath, sheetName, locatorType);
        }
    }
}
