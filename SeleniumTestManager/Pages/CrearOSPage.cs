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



        IWebElement btnOS => driver.FindElement(locator_OSLink);
        IWebElement btnCrear_OS => driver.FindElement(locator_CrearOSLink);
        IWebElement inputCustomer => driver.FindElement(locator_InputCustomer);
        IWebElement itemCustomer => driver.FindElement(locator_ItemCustomer);
        IWebElement inputSeller => driver.FindElement(locator_InputSeller);
        IWebElement selectorServiceType => driver.FindElement(locator_SelectorServiceType);
        IWebElement itemServiceType => driver.FindElement(locator_ItemServiceType);
        
        IWebElement selectorOperation => driver.FindElement(locator_SelectorOperation);
        IWebElement itemOperation => driver.FindElement(locator_ItemOperation);
        IWebElement inputShip => driver.FindElement(locator_InputShips);
        IWebElement inputTotal => driver.FindElement(locator_InputTotal);
        IWebElement btnAgregarDocumento => driver.FindElement(locator_AgregarDocumento);
        IWebElement btnEliminarDocumento => driver.FindElement(locator_EliminarDocumento);
        IWebElement btnAceptarEliminarDocumento => driver.FindElement(locator_aceptarEliminarDocumento);
        IWebElement btnCancelarEliminarDocumento => driver.FindElement(locator_cancelarEliminarDocumento);
        IWebElement selectorPrimerDocumento => driver.FindElement(locator_PrimerDocumento);
        IWebElement ItemDocumentoSeleccionado => driver.FindElement(locator_DocumentoSeleccionado);
        IWebElement ItemTipoDocumentoSeleccionado => driver.FindElement(locator_TipoDocumentoSeleccionado);
        IWebElement CheckBoxDocumentoSeleccionado => driver.FindElement(locator_CheckBoxDocumentoSeleccionado);

        IWebElement btnAgregarOrdenVenta => driver.FindElement(locator_agregarOrdenVenta);
        IWebElement selectorTipoServicio => driver.FindElement(locator_tipoServicio);
        IWebElement itemServicio => driver.FindElement(locator_itemServicio);
        IWebElement selectorTipoCarga => driver.FindElement(locator_tipoCarga);
        IWebElement itemCarga => driver.FindElement(locator_itemCarga);
        IWebElement selectorTipoSubServicio => driver.FindElement(locator_tipoSubServicio);
        IWebElement itemSubServicio => driver.FindElement(locator_itemSubServicio);
        IWebElement selectorComodity => driver.FindElement(locator_comodity);
        IWebElement inputTramo => driver.FindElement(locator_tramo);
        IWebElement checkboxTarifaUnitaria => driver.FindElement(locator_tarifaUnitaria);
        IWebElement checkboxTarifaPorcentaje => driver.FindElement(locator_tarifaPorcentaje);
        IWebElement selectorIMO => driver.FindElement(locator_IMO);
        IWebElement itemIMO => driver.FindElement(locator_itemIMO);
        IWebElement selectorUnidad => driver.FindElement(locator_unidad);
        IWebElement itemUnidad => driver.FindElement(locator_itemUnidad);
        IWebElement selectorMonedaVenta => driver.FindElement(locator_monedaVenta);
        IWebElement itemMonedaVenta => driver.FindElement(locator_itemMonedaVenta);
        IWebElement inputMonedaCantidad => driver.FindElement(locator_monedaCantidad);
        IWebElement labelMonedaCantidad => driver.FindElement(locator_labelMonedaCantidad);

        IWebElement tarifario => driver.FindElement(locator_tarifario);
        IWebElement solicitarNuevaTarifa => driver.FindElement(locator_solicitarNuevaTarifa);
        IWebElement asignarTarifa => driver.FindElement(locator_asignarTarifa);
        IWebElement cancelarTarifa => driver.FindElement(locator_cancelarTarifa);

        IWebElement inputElement => driver.FindElement(locator_elemento);

        public void CrearOS()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator_OSLink));
            btnOS.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(locator_CrearOSLink));
            btnCrear_OS.Click();
        }

        public void FillHeader(string customer, string seller, string ship, string total)
        {
            //wait.Until(ExpectedConditions.ElementIsVisible(locator_SelectorServiceType));
            //selectorServiceType.Click();
            //wait.Until(ExpectedConditions.ElementIsVisible(locator_ItemServiceType));
            //itemServiceType.Click();

            selectorServiceType.ClickIndexFromList(driver, wait, 0);

            wait.Until(ExpectedConditions.ElementIsVisible(locator_SelectorOperation));
            selectorOperation.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(locator_ItemOperation));
            itemOperation.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_InputCustomer));
            inputCustomer.Click();
            inputCustomer.EnterText(customer);
            wait.Until(ExpectedConditions.ElementIsVisible(locator_ItemCustomer));
            itemCustomer.Click();

            inputSeller.Click();
            inputSeller.EnterText(seller);

            inputShip.Click();
            inputShip.EnterText(ship);

            inputTotal.Click();
            inputTotal.EnterText(total);

            btnAgregarDocumento.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_PrimerDocumento));
            selectorPrimerDocumento.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_DocumentoSeleccionado));
            ItemDocumentoSeleccionado.Click();

            CheckBoxDocumentoSeleccionado.Click();

            btnEliminarDocumento.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_cancelarEliminarDocumento));
            btnCancelarEliminarDocumento.Click();

            btnEliminarDocumento.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_aceptarEliminarDocumento));
            btnAceptarEliminarDocumento.Click();
        }

        public void FillOV()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator_agregarOrdenVenta));
            btnAgregarOrdenVenta.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_tipoServicio));
            // selectorTipoServicio.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_itemServicio));
            // itemServicio.Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", selectorTipoSubServicio);

            wait.Until(ExpectedConditions.ElementIsVisible(locator_tipoSubServicio));
            selectorTipoSubServicio.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_itemSubServicio));
            itemSubServicio.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_tipoCarga));
            selectorTipoCarga.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_itemCarga));
            itemCarga.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_comodity));
            // selectorComodity.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_tramo));
            // inputTramo.+EnterText("");

            wait.Until(ExpectedConditions.ElementIsVisible(locator_tarifaUnitaria));
            checkboxTarifaUnitaria.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_tarifaPorcentaje));
            // checkboxTarifaPorcentaje.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_IMO));
            selectorIMO.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_itemIMO));
            itemIMO.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_unidad));
            selectorUnidad.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_itemUnidad));
            itemUnidad.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_monedaVenta));
            // selectorMonedaVenta.Click();

            // wait.Until(ExpectedConditions.ElementIsVisible(locator_itemMonedaVenta));
            // itemMonedaVenta.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(locator_monedaCantidad));
            inputMonedaCantidad.Click();
            labelMonedaCantidad.Click();
        }

        public void AgregarTarifa()
        {
            tarifario.Click();
            asignarTarifa.Click();
        }

        public void SelectServiceType(int index)
        {
            // Haz clic en el selector para desplegar las opciones
            wait.Until(ExpectedConditions.ElementIsVisible(locator_SelectorServiceType));
            selectorServiceType.Click();

            // Encuentra todos los elementos que coinciden con ItemServiceType
            wait.Until(ExpectedConditions.ElementIsVisible(locator_ItemsServiceType));
            var serviceTypeItems = driver.FindElements(locator_ItemsServiceType);

            // Verifica que el índice sea válido
            if (index >= 0 && index < serviceTypeItems.Count)
            {
                // Haz clic en el elemento que corresponde al índice dado
                serviceTypeItems[index].Click();
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Índice {index} fuera de rango. Hay {serviceTypeItems.Count} elementos disponibles.");
            }
        }
    }
}
