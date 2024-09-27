using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;
using SeleniumTestManager.Locators;

namespace SeleniumTestManager.Pages
{
    public class CrearOSPage : BasePage
    {
        public CrearOSPage(IWebDriver driver) : base(driver) 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        

        private By locator_CrearOSLink = DashboardPageLocators.CrearOSLink;
        private By locator_OSLink = DashboardPageLocators.OSLink;
        private By locator_InputCustomer = DashboardPageLocators.InputCustomer;
        private By locator_ItemCustomer = DashboardPageLocators.ItemCustomer;
        private By locator_InputSeller = DashboardPageLocators.InputSeller;
        private By locator_SelectorServiceType =  DashboardPageLocators.SelectorServiceType;
        private By locator_ItemServiceType = DashboardPageLocators.ItemServiceType;
        private By locator_ItemsServiceType = DashboardPageLocators.ItemsServiceType;
        private By locator_SelectorOperation = DashboardPageLocators.SelectorOperation;
        private By locator_ItemOperation = DashboardPageLocators.ItemOperation;
        private By locator_InputShips = DashboardPageLocators.InputShips;
        private By locator_InputTotal = DashboardPageLocators.InputTotal;
        private By locator_AgregarDocumento = DashboardPageLocators.AgregarDocumento;
        private By locator_EliminarDocumento = DashboardPageLocators.EliminarDocumento;
        private By locator_PrimerDocumento = DashboardPageLocators.primerDocumento;
        private By locator_DocumentoSeleccionado = DashboardPageLocators.documentoSeleccionado;
        private By locator_TipoDocumentoSeleccionado = DashboardPageLocators.tipoDocumentoSeleccionado;
        private By locator_CheckBoxDocumentoSeleccionado = DashboardPageLocators.checkboxDocumento;
        private By locator_aceptarEliminarDocumento = DashboardPageLocators.aceptarEliminarDocumento;
        private By locator_cancelarEliminarDocumento = DashboardPageLocators.cancelarEliminarDocumento;

        private By locator_agregarOrdenVenta = DashboardPageLocators.agregarOrdenVenta;
        private By locator_tipoServicio = DashboardPageLocators.tipoServicio;
        private By locator_itemServicio = DashboardPageLocators.itemServicio;
        private By locator_tipoCarga = DashboardPageLocators.tipoCarga;
        private By locator_itemCarga = DashboardPageLocators.itemCarga;
        private By locator_tipoSubServicio = DashboardPageLocators.tipoSubServicio;
        private By locator_itemSubServicio = DashboardPageLocators.itemSubServicio;
        private By locator_comodity = DashboardPageLocators.comodity;
        private By locator_tramo = DashboardPageLocators.tramo;
        private By locator_tarifaUnitaria = DashboardPageLocators.tarifaUnitaria;
        private By locator_tarifaPorcentaje = DashboardPageLocators.tarifaPorcentaje;
        private By locator_IMO = DashboardPageLocators.IMO;
        private By locator_itemIMO = DashboardPageLocators.itemIMO;
        private By locator_unidad = DashboardPageLocators.unidad;
        private By locator_itemUnidad = DashboardPageLocators.itemUnidad;
        private By locator_monedaVenta = DashboardPageLocators.monedaVenta;
        private By locator_itemMonedaVenta = DashboardPageLocators.itemMonedaVenta;
        private By locator_monedaCantidad = DashboardPageLocators.monedaCantidad;
        private By locator_labelMonedaCantidad = DashboardPageLocators.labelMonedaCantidad;

        private By locator_tarifario = DashboardPageLocators.tarifario;
        private By locator_solicitarNuevaTarifa = DashboardPageLocators.solicitarNuevo;
        private By locator_asignarTarifa = DashboardPageLocators.asignar;
        private By locator_cancelarTarifa = DashboardPageLocators.cancelar;

        private By locator_elemento = DashboardPageLocators.element;



        IWebElement BtnOS => driver.FindElement(locator_OSLink);
        IWebElement BtnCrear_OS => driver.FindElement(locator_CrearOSLink);
        IWebElement InputCustomer => driver.FindElement(locator_InputCustomer);
        IWebElement ItemCustomer => driver.FindElement(locator_ItemCustomer);
        IWebElement InputSeller => driver.FindElement(locator_InputSeller);
        IWebElement SelectorServiceType => driver.FindElement(locator_SelectorServiceType);
        IWebElement ItemServiceType => driver.FindElement(locator_ItemServiceType);
        
        IWebElement SelectorOperation => driver.FindElement(locator_SelectorOperation);
        IWebElement ItemOperation => driver.FindElement(locator_ItemOperation);
        IWebElement InputShip => driver.FindElement(locator_InputShips);
        IWebElement InputTotal => driver.FindElement(locator_InputTotal);
        IWebElement BtnAgregarDocumento => driver.FindElement(locator_AgregarDocumento);
        IWebElement BtnEliminarDocumento => driver.FindElement(locator_EliminarDocumento);
        IWebElement BtnAceptarEliminarDocumento => driver.FindElement(locator_aceptarEliminarDocumento);
        IWebElement BtnCancelarEliminarDocumento => driver.FindElement(locator_cancelarEliminarDocumento);
        IWebElement SelectorPrimerDocumento => driver.FindElement(locator_PrimerDocumento);
        IWebElement ItemDocumentoSeleccionado => driver.FindElement(locator_DocumentoSeleccionado);
        IWebElement ItemTipoDocumentoSeleccionado => driver.FindElement(locator_TipoDocumentoSeleccionado);
        IWebElement CheckBoxDocumentoSeleccionado => driver.FindElement(locator_CheckBoxDocumentoSeleccionado);

        IWebElement BtnAgregarOrdenVenta => driver.FindElement(locator_agregarOrdenVenta);
        IWebElement SelectorTipoServicio => driver.FindElement(locator_tipoServicio);
        IWebElement ItemServicio => driver.FindElement(locator_itemServicio);
        IWebElement SelectorTipoCarga => driver.FindElement(locator_tipoCarga);
        IWebElement ItemCarga => driver.FindElement(locator_itemCarga);
        IWebElement SelectorTipoSubServicio => driver.FindElement(locator_tipoSubServicio);
        IWebElement ItemSubServicio => driver.FindElement(locator_itemSubServicio);
        IWebElement SelectorComodity => driver.FindElement(locator_comodity);
        IWebElement InputTramo => driver.FindElement(locator_tramo);
        IWebElement CheckboxTarifaUnitaria => driver.FindElement(locator_tarifaUnitaria);
        IWebElement CheckboxTarifaPorcentaje => driver.FindElement(locator_tarifaPorcentaje);
        IWebElement SelectorIMO => driver.FindElement(locator_IMO);
        IWebElement ItemIMO => driver.FindElement(locator_itemIMO);
        IWebElement SelectorUnidad => driver.FindElement(locator_unidad);
        IWebElement ItemUnidad => driver.FindElement(locator_itemUnidad);
        IWebElement SelectorMonedaVenta => driver.FindElement(locator_monedaVenta);
        IWebElement ItemMonedaVenta => driver.FindElement(locator_itemMonedaVenta);
        IWebElement InputMonedaCantidad => driver.FindElement(locator_monedaCantidad);
        IWebElement LabelMonedaCantidad => driver.FindElement(locator_labelMonedaCantidad);

        IWebElement Tarifario => driver.FindElement(locator_tarifario);
        IWebElement SolicitarNuevaTarifa => driver.FindElement(locator_solicitarNuevaTarifa);
        IWebElement AsignarTarifa => driver.FindElement(locator_asignarTarifa);
        IWebElement CancelarTarifa => driver.FindElement(locator_cancelarTarifa);

        IWebElement InputElement => driver.FindElement(locator_elemento);

        public void CrearOS()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator_OSLink));
            BtnOS.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(locator_CrearOSLink));
            BtnCrear_OS.Click();
        }

        public void FillHeader(string customer, string seller, string ship, string total)
        {
            //wait.Until(ExpectedConditions.ElementIsVisible(locator_SelectorServiceType));
            //selectorServiceType.Click();
            //wait.Until(ExpectedConditions.ElementIsVisible(locator_ItemServiceType));
            //itemServiceType.Click();

            SelectorServiceType.ClickIndexFromList(0);

            wait.Until(ExpectedConditions.ElementIsVisible(locator_SelectorOperation));
            SelectorOperation.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(locator_ItemOperation));
            ItemOperation.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_InputCustomer));
            InputCustomer.Click();
            InputCustomer.EnterText(customer);
            wait.Until(ExpectedConditions.ElementIsVisible(locator_ItemCustomer));
            ItemCustomer.Click();

            InputSeller.Click();
            InputSeller.EnterText(seller);

            InputShip.Click();
            InputShip.EnterText(ship);

            InputTotal.Click();
            InputTotal.EnterText(total);

            BtnAgregarDocumento.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_PrimerDocumento));
            SelectorPrimerDocumento.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_DocumentoSeleccionado));
            ItemDocumentoSeleccionado.Click();

            CheckBoxDocumentoSeleccionado.Click();

            BtnEliminarDocumento.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_cancelarEliminarDocumento));
            BtnCancelarEliminarDocumento.Click();

            BtnEliminarDocumento.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_aceptarEliminarDocumento));
            BtnAceptarEliminarDocumento.Click();
        }

        public void FillOV()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator_agregarOrdenVenta));
            BtnAgregarOrdenVenta.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_tipoServicio));
            // selectorTipoServicio.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_itemServicio));
            // itemServicio.Click();

            driver.ScrollToLocator(SelectorTipoSubServicio);

            wait.Until(ExpectedConditions.ElementIsVisible(locator_tipoSubServicio));
            SelectorTipoSubServicio.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_itemSubServicio));
            ItemSubServicio.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_tipoCarga));
            SelectorTipoCarga.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_itemCarga));
            ItemCarga.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_comodity));
            // selectorComodity.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_tramo));
            // inputTramo.+EnterText("");

            wait.Until(ExpectedConditions.ElementIsVisible(locator_tarifaUnitaria));
            CheckboxTarifaUnitaria.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_tarifaPorcentaje));
            // checkboxTarifaPorcentaje.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_IMO));
            SelectorIMO.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_itemIMO));
            ItemIMO.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_unidad));
            SelectorUnidad.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_itemUnidad));
            ItemUnidad.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_monedaVenta));
            // selectorMonedaVenta.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_itemMonedaVenta));
            // itemMonedaVenta.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_monedaCantidad));
            InputMonedaCantidad.Click();
            LabelMonedaCantidad.Click();
        }

        public void AgregarTarifa()
        {
            Tarifario.Click();
            AsignarTarifa.Click();
        }
    }
}
