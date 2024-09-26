using CsvHelper.Configuration;
using CsvHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumTestManager.Models;
using SeleniumTestManager.Pages;
using System.Globalization;
using System.IO;
using System.Text.Json;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework.Interfaces;
using ClosedXML;

namespace SeleniumTestManager.Tests
{
    public class Tests
    {
        private IWebDriver _driver;
        private List<TestResult> _testResults;
        private Stopwatch _stopwatch;
        private string _filePath;
        private string _url;
        private string _testFolder;
        private string _reportFilePath;
        private string _screenshotsFolder;
        private string _screenshotFilePath;
        private string _testName;
        private DateTime _startTime;
        private DateTime _endTime;
        private string _errorMessage;
        private string _stackTrace;
        private string _environment;


        public static IEnumerable<LoginModel> CSVDataSource(string csvFilePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";", // Cambia esto si es necesario
            };
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<LoginModel>().ToList();
                foreach (var item in records)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<LoginModel> ExcelDataSource(string excelFilePath, string sheetName)
        {
            using (var workbook = new XLWorkbook(excelFilePath))
            {
                var worksheet = workbook.Worksheet(sheetName);
                var rows = worksheet.RowsUsed().Skip(1); // Asumiendo que la primera fila es el encabezado

                foreach (var row in rows)
                {
                    var loginModel = new LoginModel
                    {
                        Username = row.Cell(1).GetValue<string>(),
                        Password = row.Cell(2).GetValue<string>()
                    };

                    yield return loginModel;
                }
            }
        }

        public void TakeScreenShot(string fileName)
        {
            //Guarda una captura de pantalla
            _screenshotFilePath = Path.Combine(_screenshotsFolder, fileName);
            _driver.TakeScreenshot(_screenshotFilePath);
        }


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Define una url para acceder a la aplicacion
            _url = "https://slim-qa.ulog.cl/Account/Login";

            // Define una direccion para guardar los datos de la prueba
            _filePath = "E:\\UltraMar\\";

            // Define un ambiente
            _environment = "QA";

            // Crea la carpeta para el test
            _testFolder = Path.Combine(_filePath, $"Test_Results_{DateTime.Now:yyyyMMdd_HHmmss}");
            if (!Directory.Exists(_testFolder))
            {
                Directory.CreateDirectory(_testFolder);
            }

            // Inicializa la lista de resultados
            _testResults = new List<TestResult>();

            //Define la direccion del archivo excel que contendra los resultados
            _reportFilePath = Path.Combine(_testFolder, "TestReport.xlsx");

            // Crear el archivo Excel si no existe
            if (!File.Exists(_reportFilePath))
            {
                Utils.CreateTestReport(_reportFilePath);
            }
        }

        [SetUp]
        public void Setup()
        {
            //Obtiene el nombre del test
            _testName = TestContext.CurrentContext.Test.Name;
            _startTime = DateTime.Now;
            _endTime = DateTime.Now;

            // Crea la subcarpeta para los screenshots
            _screenshotsFolder = Path.Combine(_testFolder, $"{_testName}_screenshots");
            Directory.CreateDirectory(_screenshotsFolder);

            // Inicia el driver
            DriverManager driverInstance = new DriverManager("chrome");
            _driver = driverInstance.GetDriver();
            _driver.Navigate().GoToUrl(_url);

            // Inicia el cronómetro
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        [TearDown]
        public void TearDown()
        {
            // Detiene el cronómetro
            _stopwatch.Stop();

            // Guarda el resultado del test actual
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status.ToString();
            var executionTime = _stopwatch.Elapsed;

            // Guarda el mensaje en caso de error
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                _errorMessage = TestContext.CurrentContext.Result.Message;
            }
            else
            {
                _errorMessage = string.Empty; // O algún mensaje por defecto para pruebas exitosas.
            }

            // Guarda el StackTrace del error
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                _stackTrace = TestContext.CurrentContext.Result.StackTrace;
            }
            else
            {
                _stackTrace = string.Empty; // O algún valor por defecto.
            }

            // Escribir los resultados al archivo Excel
            Utils.RegisterTestResportData(_reportFilePath, _testName, testStatus, executionTime, _startTime, _endTime, _errorMessage, _stackTrace, _environment);

            // Cerrar el WebDriver
            _driver.Close();
        }

        [Test]
        public void RutaCritica()
        {
            //POM Initialization
            //Arrange 
            LoginPage loginPage = new LoginPage(_driver);
            CrearOSPage crearOSPage = new CrearOSPage(_driver);
            //Act
            TakeScreenShot("screenshot_1.png");
            loginPage.Login("gabriel.diaz_ext", "Gd31z.2024$.");
            TakeScreenShot("screenshot_2.png");
            crearOSPage.CrearOS();
            TakeScreenShot("screenshot_3.png");
            crearOSPage.FillHeader("85939500-7", "Felipe Retamal Caamaño", "barquito chu chu", "99999");
            TakeScreenShot("screenshot_4.png");
            crearOSPage.FillOV();
            TakeScreenShot("screenshot_5.png");

            //Assert
            Assert.Pass();

        }

        [Test]
        public void ExtraerLocalizadoresExcel()
        {
            //POM Initialization
            //Arrange 
            LoginPageExcel loginPage = new LoginPageExcel(_driver, "CssSelector");
            //Act
            loginPage.Login("gabriel.diaz_ext", "Gd31z.2024$.");

            //Assert
            Assert.Pass();
        }

        [Test]
        [Category("ddt")]
        [TestCaseSource(nameof(CSVDataSource), new object[] { "Login.csv" })] //Nombre del archivo csv
        public void CargaMasivaCSV(LoginModel loginModel)
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login(loginModel.Username, loginModel.Password);
            Assert.Pass();
        }

        [Test]
        [Category("ddt")]
        [TestCaseSource(nameof(ExcelDataSource), new object[] { "Login.xlsx", "Sheet1" })] //Nombre del archivo xlsx y nombre de la hoja
        public void CargaMasivaExcel(LoginModel loginModel)
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login(loginModel.Username, loginModel.Password);
            Assert.Pass();
        }
    }
}