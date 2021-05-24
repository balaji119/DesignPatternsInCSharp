namespace DesignPatternsInCSharp.State
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            System.Console.WriteLine("Slection tool selected.");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Draw a rectange.");
        }
    }
}