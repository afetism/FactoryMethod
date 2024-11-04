using System.Security.Cryptography.X509Certificates;

namespace FactoryMethod;

public abstract class DialogFactory
{
	public abstract Button CreateButton();

	public void Render()
	{
		var button = CreateButton();
		button.render();
	}
	public void Click()
	{
		var button =CreateButton();
		button.onClick();
	}
}
