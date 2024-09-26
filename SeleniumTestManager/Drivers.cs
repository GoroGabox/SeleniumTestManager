using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;

public class DriverManager
{
    private string type;
    private IWebDriver driver;

    public DriverManager(string type)
    {
        this.type = type.ToLower(); // Asegura que el tipo de navegador sea manejado en minúsculas
        switch (this.type)
        {
            case "chrome":
                this.driver = new ChromeDriver();
                break;
            case "firefox":
                this.driver = new FirefoxDriver();
                break;
            case "edge":
                this.driver = new EdgeDriver();
                break;
            default:
                throw new ArgumentException("Navegador no soportado: " + type);
        }
    }

    public IWebDriver GetDriver()
    {
        this.driver.Manage().Window.Maximize();
        return this.driver;
    }
}
