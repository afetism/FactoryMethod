namespace FactoryMethod;

public class WindowsButton : Button
{
	public void onClick()
	{
        Console.WriteLine("Windows Button Clicked!");
    }

	public void render()
	{
		Console.WriteLine("Windows Button Redering!");
	}
}
