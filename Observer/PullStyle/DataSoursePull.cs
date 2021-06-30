namespace DesignPatternsInCSharp.Observer.PullStyle
{
    public class DataSoursePull : SubjectPull
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
                Notify();
            }
        }
        private int data;
    }
}
