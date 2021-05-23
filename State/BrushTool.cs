public class BrushTool : ITool
{
    public void MouseDown()
    {
        System.Console.WriteLine("Brush tool selected.");
    }

    public void MouseUp()
    {
        System.Console.WriteLine("Draw a line.");
    }
}
