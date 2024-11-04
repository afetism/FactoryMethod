namespace FactoryMethod;

public class HtmlDialog : DialogFactory
{
	public override Button CreateButton()=>new HtmlButton();
}
