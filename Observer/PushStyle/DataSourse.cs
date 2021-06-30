namespace DesignPatternsInCSharp.Observer.PushStyle
{
    public class DataSourse : Subject
    {
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                Notify(data);
            }
        }

        private int data;
    }
}
