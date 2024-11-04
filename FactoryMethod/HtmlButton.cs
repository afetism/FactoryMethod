namespace FactoryMethod;

public class HtmlButton : Button
{
	public void onClick()
	{
        Console.WriteLine("Html button Clicked!");
    }

	public void render()
	{
		Console.WriteLine("Html button Rendering!");
	}
}
