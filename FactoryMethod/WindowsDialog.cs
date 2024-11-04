namespace FactoryMethod;

internal class WindowsDialog : DialogFactory
{
	
	public override Button CreateButton()=>new WindowsButton();
}
