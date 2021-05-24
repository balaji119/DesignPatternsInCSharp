namespace DesignPatternsInCSharp.State
{
    public class Canvas
    {
        private ITool currentTool;

        public ITool CurrentTool
        {
            get
            {
                return currentTool;
            }
            set
            {
                currentTool = value;
            }
        }

        public void MouseDown()
        {
            currentTool.MouseDown();
        }

        public void MouseUp()
        {
            currentTool.MouseUp();
        }
    }
}