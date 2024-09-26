using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestManager
{
    public static class Utils
    {
        // Métodos para elementos web
        public static void Click(this IWebElement locator)
        {
            locator.Click();
        }

        public static void Submit(this IWebElement locator)
        {
            locator.Submit();
        }

        public static void EnterText(this IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        public static void SelectDropDownByText(this IWebElement locator, string text) 
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByText(text);
        }

        public static void SelectDropDownByValue(this IWebElement locator, string value)
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByValue(value);
        }

        public static void MultiSelectElements(this IWebElement locator, string[] values)
        {
            SelectElement multiselect = new SelectElement(locator);

            foreach (var value in values)
            {
                multiselect.SelectByValue(value);
            }
        }

        public static List<string> GetAllSelectedElements(this IWebElement locator)
        {
            List<string> options = new List<string>();
            SelectElement multiselect = new SelectElement(locator);

            var selectedOptions = multiselect.AllSelectedOptions;

            foreach (IWebElement option in selectedOptions)
            {
                options.Add(option.Text);
            }

            return options;
        }

        public static void ClickIndexFromList(this IWebElement listElement, IWebDriver driver, WebDriverWait wait, int index)
        {
            listElement.Click();

            var listItems = listElement.FindElements(By.XPath("./*"));

            if (index >= 0 && index < listItems.Count)
            {
                listItems[index].Click();
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Índice {index} fuera de rango. Hay {listItems.Count} elementos disponibles.");
            }
        }

        public static void ClickItemFromList(this IWebElement listElement, IWebDriver driver, WebDriverWait wait, By locatorListItems)
        {
            listElement.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locatorListItems));

            var listItems = driver.FindElements(locatorListItems);

            if (listItems.Count > 0)
            {
                listItems[0].Click();
            }
            else
            {
                throw new NoSuchElementException($"No se encontraron elementos con el localizador {locatorListItems}");
            }
        }
        
        public static void UploadFile(this IWebElement fileInputElement, string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"El archivo no se encontró en la ruta: {filePath}");
            }
            fileInputElement.SendKeys(filePath);
        }

        // Métodos adicionales
        public static void TakeScreenshot(this IWebDriver driver, string fileName)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(fileName);
        }

        public static void CreateTestReport(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Test Results");

                // Escribir encabezados
                worksheet.Cell(1, 1).Value = "Test Name";
                worksheet.Cell(1, 2).Value = "Status";
                worksheet.Cell(1, 3).Value = "Execution Time";
                worksheet.Cell(1, 4).Value = "Start Time";
                worksheet.Cell(1, 5).Value = "End Time";
                worksheet.Cell(1, 6).Value = "Error Message";
                worksheet.Cell(1, 7).Value = "Stack Trace";
                worksheet.Cell(1, 8).Value = "Environment";

                // Guardar el archivo Excel
                workbook.SaveAs(filePath);
            }
        }
    
        public static void RegisterTestResportData(string filePath, string testName, string testStatus, TimeSpan executionTime, DateTime startTime, DateTime endTime, string errorMessage, string stackTrace, string environment)
        {
            // Escribir los resultados al archivo Excel
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet("Test Results");
                var lastRow = worksheet.LastRowUsed().RowNumber();
                worksheet.Cell(lastRow + 1, 1).Value = testName;
                worksheet.Cell(lastRow + 1, 2).Value = testStatus;
                worksheet.Cell(lastRow + 1, 3).Value = executionTime.ToString(@"hh\:mm\:ss\.fff");
                worksheet.Cell(lastRow + 1, 4).Value = startTime.ToString("yyyy-MM-dd HH:mm:ss");
                worksheet.Cell(lastRow + 1, 5).Value = endTime.ToString("yyyy-MM-dd HH:mm:ss");
                worksheet.Cell(lastRow + 1, 6).Value = errorMessage;
                worksheet.Cell(lastRow + 1, 7).Value = stackTrace;
                worksheet.Cell(lastRow + 1, 8).Value = environment;
                workbook.Save();
            }
        }
    }    
}
