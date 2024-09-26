using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using OpenQA.Selenium;
using SeleniumTestManager.Models;

namespace SeleniumTestManager.Locators
{
    public static class LoginPageLocators
    {
        public static By InputUsuario = By.Id("Username");
        public static By InputPassword = By.Id("Password");
        public static By ButtonIngresar = By.CssSelector(".btn");
    }

    public static class DashboardPageLocators
    {
        public static By OSLink = By.CssSelector("li:nth-child(2) .collapse-sign > .fa");
        public static By CrearOSLink = By.CssSelector(".open > ul:nth-child(2) > li:nth-child(2)");

        public static By InputCustomer = By.CssSelector("div.form-horizontal:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > ul-business-partner:nth-child(1) > div:nth-child(1) > span:nth-child(1) > input:nth-child(1)");
        public static By ItemCustomer = By.CssSelector(".body > tbody:nth-child(1) > tr:nth-child(1)");
        public static By InputSeller = By.CssSelector("input.ng-invalid");
        public static By SelectorServiceType = By.CssSelector("div.form-horizontal:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > span:nth-child(1)");
        public static By ItemServiceType = By.CssSelector("div.k-animation-container:nth-child(11) > div:nth-child(1) > div:nth-child(3) > ul:nth-child(1) > li:nth-child(1)");
        public static By ItemsServiceType = By.CssSelector("div.k-animation-container:nth-child(11) > div:nth-child(1) > div:nth-child(3) > ul:nth-child(1) > li");
        public static By SelectorOperation = By.CssSelector("div.form-horizontal:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > span:nth-child(1) > span:nth-child(1) > span:nth-child(1)");
        public static By ItemOperation = By.CssSelector("div.k-animation-container:nth-child(12) > div:nth-child(1) > div:nth-child(3) > ul:nth-child(1) > li:nth-child(1)");
        public static By InputShips = By.CssSelector("input.k-textbox:nth-child(2)");
        public static By InputTotal = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[1]/div/div/div[5]/div[2]/div/div/input");
        public static By AgregarDocumento = By.CssSelector("div.panel-body:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > button:nth-child(2)");
        public static By primerDocumento = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[2]/div[2]/div/div[2]/table/tbody/tr/td[2]/span/span");
        public static By documentoSeleccionado = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[2]/div[2]/div/div[2]/table/tbody/tr/td[2]/span/span/span[1]");
        public static By tipoDocumentoSeleccionado = By.XPath("/html/body/div[48]/div/div[3]/ul/li[1]");
        public static By checkboxDocumento = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[2]/div[2]/div/div[2]/table/tbody/tr/td[1]/div/input");
        public static By EliminarDocumento = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[2]/div[1]/div/div/div[2]/button[1]");
        public static By aceptarEliminarDocumento = By.Id("bot2-Msg1");
        public static By cancelarEliminarDocumento = By.Id("bot1-Msg1");

        public static By agregarOrdenVenta = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[1]/div[1]/button[2]");
        public static By tipoServicio = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[5]/div[1]/div/span/span/span[1]");
        public static By itemServicio = By.XPath("//*[@id=\"a03f7e91-67a5-46e7-a7ca-ee26ed5bc8a7\"]");
        public static By tipoCarga = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[6]/div[1]/div/div/span/span/span[1]");
        public static By itemCarga = By.CssSelector("#kddlCargoTypeSaleOrder_listbox > li:nth-child(1)");
        public static By tipoSubServicio = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[5]/div[2]/div/span/span/span[1]");
        public static By itemSubServicio = By.CssSelector("#kddlSubServiceTypeSaleOrder_listbox > li:nth-child(1)");

        public static By comodity = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[6]/div[2]/div/div/span/span/span[1]");
        public static By tramo = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[7]/div[1]/div/div/ul-leg/div/span/input");
        public static By tarifaUnitaria = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[5]/div[3]/label[2]/input");
        public static By tarifaPorcentaje = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[5]/div[3]/label[3]/input");
        public static By IMO = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[6]/div[3]/div/div/span/span/span[1]");
        public static By itemIMO = By.CssSelector("#kddlImoSaleOrder_listbox > li:nth-child(1)");
        public static By unidad = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[7]/div[2]/div/div/span/span/span[1]");
        public static By itemUnidad = By.CssSelector("#kddlMeasureUnitSaleOrder_listbox > li:nth-child(1)");
        public static By monedaVenta = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[8]/div[1]/div/span/span/span[1]");
        public static By itemMonedaVenta = By.CssSelector("div.k-animation-container:nth-child(72) > div:nth-child(1) > div:nth-child(3) > ul:nth-child(1) > li:nth-child(2)");
        public static By monedaCantidad = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[9]/div[1]/div[1]/div/span/span/input[1]");
        public static By labelMonedaCantidad = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[2]/div/div[9]/div[1]/div[1]/label");

        public static By tarifario = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[2]/div/div/div/div/div/div[2]/div/div[1]/div/div/div[1]/button[3]/ng-access-label");
        public static By solicitarNuevo = By.XPath("/html/body/div[64]/div/div[3]/ul/li[1]");
        public static By asignar = By.XPath("/html/body/div[64]/div/div[3]/ul/li[1]");
        public static By cancelar = By.XPath("/html/body/div[64]/div/div[3]/ul/li[1]");

        public static By element = By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[1]/div/div/div/section/article/div/div/div/div[2]/div[1]/div[1]/div/div/div[2]/input");
    }

}
