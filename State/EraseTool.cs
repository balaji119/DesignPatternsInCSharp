namespace DesignPatternsInCSharp.State
{
    public class EraseTool : ITool
    {
        public void MouseDown()
        {
            System.Console.WriteLine("Erase tool selected.");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Erase.");
        }
    }
}