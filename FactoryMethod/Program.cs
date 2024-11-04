using FactoryMethod;

var htmButton = new HtmlDialog();
htmButton.Render();
var windowsButton = new WindowsDialog();
windowsButton.Render();
htmButton.Click();